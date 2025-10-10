using BL.Contracts;
using BL.Services;
using Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Student
{
    public partial class TakeExamForm : Form
    {

        private readonly IStudent _student;
        private Exam _exam;
        private readonly User _user;

        private List<Questions> _questions;
        private int _currentIndex = 0;
        private int _score = 0;
        private bool _answered = false;

        public TakeExamForm(IStudent student, Exam exam, User user)
        {
            InitializeComponent();
            _student = student;
            _exam = exam;
            _user = user;
        }

        private void TakeExamForm_Load(object sender, EventArgs e)
        {
            // Load questions
            _questions = _exam.Questions
                .Where(q => q.Choices != null && q.Choices.Count > 0)
                .ToList();

            if (_questions.Count == 0)
            {
                MessageBox.Show("This exam has no questions.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            _answered = false;
            btnSubmit.Enabled = true;
            btnNext.Enabled = false;
            lblFeedback.Text = "";

            var q = _questions[_currentIndex];
            lblQuestionNumber.Text = $"Question {_currentIndex + 1} of {_questions.Count}";
            lbqHeader.Text = q.Header;
            lbMarks.Text = q.Marks + " Points";
            lblQuestionBody.Text = q.Body;

            flowChoices.Controls.Clear();

            bool isMulti = q.QusetionType == QusetionType.ChoiceMultiAnswer;

            foreach (var choice in q.Choices)
            {
                Control ctrl;
                if (isMulti)
                {
                    ctrl = new CheckBox
                    {
                        Text = choice.Body,
                        AutoSize = true,
                        Tag = choice
                    };
                }
                else
                {
                    ctrl = new RadioButton
                    {
                        Text = choice.Body,
                        AutoSize = true,
                        Tag = choice
                    };
                }
                flowChoices.Controls.Add(ctrl);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_answered) return;

            var q = _questions[_currentIndex];
            var selectedChoices = flowChoices.Controls
                .OfType<CheckBox>()
                .Where(c => c.Checked)
                .Select(c => c.Tag as Choices)
                .ToList();

            // If it’s single-choice, handle radio buttons too
            if (selectedChoices.Count == 0)
            {
                selectedChoices = flowChoices.Controls
                    .OfType<RadioButton>()
                    .Where(r => r.Checked)
                    .Select(r => r.Tag as Choices)
                    .ToList();
            }

            if (selectedChoices.Count == 0)
            {
                MessageBox.Show("Please select at least one answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool correct = CheckAnswer(q, selectedChoices);

            lblFeedback.ForeColor = correct ? Color.Green : Color.Red;
            lblFeedback.Text = correct ? "✅ Correct!" : "❌ Wrong Answer";

            if (correct)
                _score += q.Marks;

            lblScore.Text = $"Score: {_score}";

            HighlightAnswers(q);
            _answered = true;
            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
        }

        private bool CheckAnswer(Questions q, List<Choices> selected)
        {
            var correctChoices = q.Choices.Where(c => c.IsCorrect).Select(c => c.ChoicesId).ToList();
            var selectedIds = selected.Select(c => c.ChoicesId).ToList();

            // correct if sets match
            return !correctChoices.Except(selectedIds).Any() && !selectedIds.Except(correctChoices).Any();
        }

        private void HighlightAnswers(Questions q)
        {
            foreach (Control ctrl in flowChoices.Controls)
            {
                var choice = ctrl.Tag as Choices;
                if (choice == null) continue;

                if (choice.IsCorrect)
                    ctrl.BackColor = Color.LightGreen;
                else if ((ctrl is CheckBox cb && cb.Checked) || (ctrl is RadioButton rb && rb.Checked))
                    ctrl.BackColor = Color.LightCoral;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show($"🎉 Practice Finished!\nYour total score: {_score}/{getTotalMarks()}", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private int getTotalMarks()
        {
            var totalMarks = 0;
            foreach(var Q in _questions)
            {
                totalMarks += Q.Marks;
            }
            return totalMarks;
        }
    }
}
