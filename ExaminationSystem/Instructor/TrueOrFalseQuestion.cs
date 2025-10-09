using BL.Services;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystem.Instructor
{
    public partial class TrueOrFalseQuestion : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ITeacher _context;
        private readonly User _user;
        private readonly Exam _exam;

        public bool BackPressed = false;

        public TrueOrFalseQuestion(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            _user = user;
            _exam = exam;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Validate input
                if (string.IsNullOrWhiteSpace(txtQuestionBody.Text))
                {
                    MessageBox.Show("Please enter the question text.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!rbTrue.Checked && !rbFalse.Checked)
                {
                    MessageBox.Show("Please choose the correct answer (True or False).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numMarks.Value <= 0)
                {
                    MessageBox.Show("Marks must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2️⃣ Create the Question
                var question = new Questions
                {
                    Header = "Choose True Or False",
                    Body = txtQuestionBody.Text.Trim(),
                    Marks = (int)numMarks.Value,
                    QusetionType = QusetionType.trueorFalse,
                    ExamId = _exam.ExamId
                };

                // 3️⃣ Create Choices
                var choices = new List<Choices>
                {
                    new Choices { Body = "True", IsCorrect = rbTrue.Checked },
                    new Choices { Body = "False", IsCorrect = rbFalse.Checked }
                };

                // 4️⃣ Save to DB
                _context.AddQuestion(_exam.ExamId, question, choices);

                MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5️⃣ Close and return to parent form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackPressed = true;
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            BackPressed = true;
            this.Close();
        }
    }
}
