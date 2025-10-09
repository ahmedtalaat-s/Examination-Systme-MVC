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
public partial class ChoiceQuestion : Form
{
    private readonly IServiceProvider _serviceProvider;

    private readonly ITeacher _context;
    private readonly User _user;
    private readonly Exam _exam;
    private List<Choices> _choices = new();

    public ChoiceQuestion(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
    {
        _context = context;
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _user = user;
        _exam = exam;
    }

    private void lbBodyQuestion_Click(object sender, EventArgs e)
    {

    }
    private void ChoiceQuestion_Load(object sender, EventArgs e)
    {
        // Configure DataGridView
        dgvChoices.AutoGenerateColumns = false;
        dgvChoices.Columns.Clear();

        // Choice text column
        dgvChoices.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Choice",
            DataPropertyName = "Body",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });

        // Radio button column
        DataGridViewButtonColumn radioCol = new DataGridViewButtonColumn
        {
            HeaderText = "Is Correct",
            Text = "✓",
            UseColumnTextForButtonValue = true,
            Width = 80
        };
        dgvChoices.Columns.Add(radioCol);

        dgvChoices.ReadOnly = true;
    }

    private void btnAddChoice_Click(object sender, EventArgs e)
    {
        string choiceText = txtChoice.Text.Trim();

        if (string.IsNullOrEmpty(choiceText))
        {
            MessageBox.Show("Please enter a choice before adding.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _choices.Add(new Choices { Body = choiceText, IsCorrect = false });
        dgvChoices.DataSource = null;
        dgvChoices.DataSource = _choices;
        txtChoice.Clear();
    }

    private void dgvChoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Make sure the click is on the radio button column
        if (e.RowIndex >= 0 && dgvChoices.Columns[e.ColumnIndex].HeaderText == "Is Correct")
        {
            // Uncheck all first
            foreach (var choice in _choices)
                choice.IsCorrect = false;

            // Set clicked one as correct
            _choices[e.RowIndex].IsCorrect = true;

            // Refresh DataGridView to reflect the change
            dgvChoices.DataSource = null;
            dgvChoices.DataSource = _choices;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // 1️⃣ Validation
        if (string.IsNullOrWhiteSpace(txtQuestionBody.Text))
        {
            MessageBox.Show("Please enter the question text.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_choices.Count < 2)
        {
            MessageBox.Show("Please add at least two choices.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!_choices.Any(c => c.IsCorrect))
        {
            MessageBox.Show("Please select the correct answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (numMark.Value <= 0)
        {
            MessageBox.Show("Mark must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2️⃣ Create Question
        var question = new Questions
        {
            Header = "Choose One Choise",

            Body = txtQuestionBody.Text.Trim(),
            Marks = (int)numMark.Value,
            QusetionType = QusetionType.ChoiceOneAnswer,
            ExamId = _exam.ExamId

        };

        try
        {
            _context.AddQuestion(_exam.ExamId, question, _choices);
            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
}

