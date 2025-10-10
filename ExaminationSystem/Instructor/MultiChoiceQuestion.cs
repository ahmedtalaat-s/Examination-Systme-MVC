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

namespace ExaminationSystem.Instructor;
public partial class MultiChoiceQuestion : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ITeacher _context;
    private readonly User _user;
    private readonly Exam _exam;

    private List<Choices> _choices = new List<Choices>();

    public MultiChoiceQuestion(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
    {
        InitializeComponent();
        _context = context;
        _serviceProvider = serviceProvider;
        _user = user;
        _exam = exam;
    }

    private void MultiChoiceQuestion_Load(object sender, EventArgs e)
    {
        dgvChoices.AutoGenerateColumns = false;
        dgvChoices.Columns.Clear();

        // Choice text column
        var colText = new DataGridViewTextBoxColumn
        {
            Name = "Body",
            HeaderText = "Choice Text",
            DataPropertyName = "Body",
            Width = 200,
        };
        dgvChoices.Columns.Add(colText);

        // Checkbox column for IsCorrect
        var colIsCorrect = new DataGridViewCheckBoxColumn
        {
            Name = "IsCorrect",
            HeaderText = "Correct?",
            DataPropertyName = "IsCorrect",
            Width = 80
        };
        dgvChoices.Columns.Add(colIsCorrect);

        dgvChoices.DataSource = new BindingList<Choices>(_choices);

        // Event for safe checkbox updates
        dgvChoices.CellClick += dgvChoices_CellClick;
    }



    private void btnAddChoice_Click(object sender, EventArgs e)
    {
        string choiceText = txtChoice.Text.Trim();

        if (string.IsNullOrWhiteSpace(choiceText))
        {
            MessageBox.Show("Please enter a choice before adding.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Prevent duplicates
        if (_choices.Any(c => c.Body.Equals(choiceText, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("This choice already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _choices.Add(new Choices
        {
            Body = choiceText,
            IsCorrect = false
        });

        dgvChoices.DataSource = null;
        dgvChoices.DataSource = _choices;

        txtChoice.Clear();
        txtChoice.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // Validation
        if (string.IsNullOrWhiteSpace(txtQuestionBody.Text))
        {
            MessageBox.Show("Please enter the question text.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (numMark.Value <= 0)
        {
            MessageBox.Show("Mark must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_choices.Count < 2)
        {
            MessageBox.Show("Please add at least two choices.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!_choices.Any(c => c.IsCorrect))
        {
            MessageBox.Show("Please select at least one correct answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Create question
            var question = new Questions
            {
                Header = "Choose Multible choises",

                Body = txtQuestionBody.Text.Trim(),
                QusetionType = QusetionType.ChoiceMultiAnswer,
                Marks = (int)numMark.Value,
                ExamId = _exam.ExamId
            };

            _context.AddQuestion(_exam.ExamId, question, _choices);
            MessageBox.Show("Question saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            txtQuestionBody.Clear();
            txtChoice.Clear();
            numMark.Value = 0;
            _choices.Clear();
            dgvChoices.DataSource = null;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while saving question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }




    private void dgvChoices_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // ✅ Ignore clicks on headers
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
            return;

        // ✅ Make sure user clicked on the checkbox column
        if (dgvChoices.Columns[e.ColumnIndex].Name == "IsCorrect")
        {
            // Toggle the checkbox manually
            bool currentValue = Convert.ToBoolean(dgvChoices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? false);
            dgvChoices.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !currentValue;

            // Update your in-memory list accordingly
            _choices[e.RowIndex].IsCorrect = !currentValue;
        }
    }


}
