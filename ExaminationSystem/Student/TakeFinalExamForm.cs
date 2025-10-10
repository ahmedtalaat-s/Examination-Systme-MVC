using BL.Contracts;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ExaminationSystem.Student
{
    public partial class TakeFinalExamForm : Form
    {
        private readonly IStudent _context;   // resolved via DI
        private readonly Exam _exam;
        private readonly User _user;

        private List<Questions> _questions;
        private int _currentIndex = 0;
        private Dictionary<int, List<int>> _selectedAnswers = new Dictionary<int, List<int>>(); // questionId -> list of chosen ChoicesId
        private int _score = 0;

        private Timer _countdownTimer;
        private DateTime _endTime;

        public TakeFinalExamForm(IStudent context,Exam exam, User user)
        {
            InitializeComponent();
            _exam = exam;
            _user = user;
            _context = context;
        }

        private void TakeFinalExamForm_Load(object sender, EventArgs e)
        {
            // Ensure questions/choices are present.
            // If your IStudent has a method to load a full Exam (with Questions & Choices), call it here.
            if (_exam.Questions == null || !_exam.Questions.Any())
            {
                // Try to fetch exam by id from the service if available - optional
                // _exam = _context.GetExamWithQuestions(_exam.ExamId);
            }

            _questions = _exam.Questions.Where(q => q != null).ToList();

            if (_questions.Count == 0)
            {
                MessageBox.Show("No questions found for this exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // compute end time for the whole exam
            var now = DateTime.Now;
            var start = _exam.StartTime;
            _endTime = start.AddMinutes(_exam.Duration);

            // If started earlier than now but still within window, allow; otherwise disallow
            if (now < start)
            {
                MessageBox.Show($"Exam hasn't started yet. Starts at {start:g}.", "Not started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            if (now > _endTime)
            {
                MessageBox.Show("Exam time has ended.", "Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            // Start countdown Timer
            _countdownTimer = new Timer { Interval = 1000 };
            _countdownTimer.Tick += CountdownTimer_Tick;
            _countdownTimer.Start();

            DisplayQuestion();
            UpdateTimerLabel();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimerLabel();

            if (DateTime.Now >= _endTime)
            {
                // time's up => auto submit
                _countdownTimer.Stop();
                MessageBox.Show("Time's up. The exam will be submitted now.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubmitExam();
            }
        }

        private void UpdateTimerLabel()
        {
            var remaining = _endTime - DateTime.Now;
            if (remaining < TimeSpan.Zero) remaining = TimeSpan.Zero;
            lblTimer.Text = $"Time left: {remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
        }

        private void DisplayQuestion()
        {
            var q = _questions[_currentIndex];
            lblQuestionNumber.Text = $"Question {_currentIndex + 1} of {_questions.Count}";
            lblQuestionBody.Text = q.Body;

            flowChoices.Controls.Clear();

            bool isMulti = q.QusetionType == QusetionType.ChoiceMultiAnswer;

            // restore previously selected choices if exist
            _selectedAnswers.TryGetValue(q.QuestionsId, out var previouslySelected);

            foreach (var choice in q.Choices)
            {
                if (isMulti)
                {
                    var cb = new CheckBox
                    {
                        AutoSize = true,
                        Text = choice.Body,
                        Tag = choice
                    };
                    if (previouslySelected != null && previouslySelected.Contains(choice.ChoicesId))
                        cb.Checked = true;

                    flowChoices.Controls.Add(cb);
                }
                else
                {
                    var rb = new RadioButton
                    {
                        AutoSize = true,
                        Text = choice.Body,
                        Tag = choice
                    };
                    if (previouslySelected != null && previouslySelected.Contains(choice.ChoicesId))
                        rb.Checked = true;

                    flowChoices.Controls.Add(rb);
                }
            }

            btnPrev.Enabled = _currentIndex > 0;
            btnNext.Enabled = _currentIndex < _questions.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                DisplayQuestion();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex > 0)
            {
                _currentIndex--;
                DisplayQuestion();
            }
        }

        private void SaveCurrentSelection()
        {
            var q = _questions[_currentIndex];
            List<int> selected = new List<int>();

            // for multi-choice
            foreach (var cb in flowChoices.Controls.OfType<CheckBox>())
            {
                if (cb.Checked && cb.Tag is Choices ch)
                    selected.Add(ch.ChoicesId);
            }

            // for single-choice
            foreach (var rb in flowChoices.Controls.OfType<RadioButton>())
            {
                if (rb.Checked && rb.Tag is Choices ch)
                {
                    if (!selected.Contains(ch.ChoicesId))
                        selected.Add(ch.ChoicesId);
                }
            }

            // store selection (will overwrite previous for this question)
            _selectedAnswers[q.QuestionsId] = selected;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Submit exam now?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _countdownTimer?.Stop();
                SaveCurrentSelection();
                SubmitExam();
            }
        }

        private void SubmitExam()
        {
            // Evaluate all questions and collect answers
            _score = 0;
            List<StudentAnswers> answers = new List<StudentAnswers>();

            foreach (var q in _questions)
            {
                _selectedAnswers.TryGetValue(q.QuestionsId, out var selectedIds);
                selectedIds = selectedIds ?? new List<int>();

                var correctIds = q.Choices.Where(c => c.IsCorrect).Select(c => c.ChoicesId).ToList();

                // Determine if the student's selection is correct
                bool isCorrect = !correctIds.Except(selectedIds).Any() && !selectedIds.Except(correctIds).Any();
                if (isCorrect)
                    _score += q.Marks;

                // Record selected answers for database
                foreach (var choiceId in selectedIds)
                {
                    var choice = q.Choices.FirstOrDefault(c => c.ChoicesId == choiceId);
                    if (choice != null)
                    {
                        answers.Add(new StudentAnswers
                        {
                            QuestionId = q.QuestionsId,
                            ChoiceId = choiceId,
                            IsCorrect = choice.IsCorrect
                        });
                    }
                }
            }

            // 🔥 Save the exam report and answers via IStudent service
            _context.SaveExamReportWithAnswers(_exam.ExamId, _user.UserId, answers);

            // Show local result
            MessageBox.Show($"Exam finished.\nYour report has been saved",
                "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }



        private void TakeFinalExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _countdownTimer?.Stop();
            _countdownTimer?.Dispose();
        }
    }
}
