using BL.Services;
using Domains;
using Microsoft.Extensions.DependencyInjection;
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
public partial class ChoseQuestionType : Form
{
    private readonly IServiceProvider _serviceProvider;

    private readonly ITeacher _context;
    private readonly User _user;
    private readonly Exam _exam;
    private string _questionType= "True Or False";
    public bool backPressed = false;

    public ChoseQuestionType(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
    {
        _context = context;
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _user = user;
        _exam = exam;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void rbTrueOrFalse_CheckedChanged(object sender, EventArgs e)
    {
        _questionType = "True Or False";
    }

    private void btnCancle_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        this.Hide();

        if (_questionType=="True Or False")
        {
            var addQuestionForm = ActivatorUtilities.CreateInstance<TrueOrFalseQuestion>(_serviceProvider, _user, _exam);

            if (this.Owner is QuestionList questionList)
            {
                addQuestionForm.Owner = questionList;

                addQuestionForm.FormClosed += (s, args) => questionList.LoadQuestion();
                addQuestionForm.FormClosed += (s, args) => Close();
                addQuestionForm.FormClosed += (s, args) => questionList.Show();
            }

            addQuestionForm.ShowDialog();
        }
       else if (_questionType == "Choose One")
        {
            var addQuestionForm = ActivatorUtilities.CreateInstance<ChoiceQuestion>(_serviceProvider, _user, _exam);

            if (this.Owner is QuestionList questionList)
            {
                addQuestionForm.Owner = questionList;
                addQuestionForm.FormClosed += (s, args) => Close();

                addQuestionForm.FormClosed += (s, args) => questionList.LoadQuestion();
                addQuestionForm.FormClosed += (s, args) => questionList.Show();
            }

            addQuestionForm.ShowDialog();

        }
       else 
        {
            var addQuestionForm = ActivatorUtilities.CreateInstance<MultiChoiceQuestion>(_serviceProvider, _user, _exam);

            if (this.Owner is QuestionList questionList)
            {
                addQuestionForm.Owner = questionList;
                addQuestionForm.FormClosed += (s, args) => Close();

                addQuestionForm.FormClosed += (s, args) => questionList.LoadQuestion();
                addQuestionForm.FormClosed += (s, args) => questionList.Show();
            }

            addQuestionForm.ShowDialog();

        }

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void rbChoice_CheckedChanged(object sender, EventArgs e)
    {
        _questionType = "Choose One";
    }

    private void rbMultiChoice_CheckedChanged(object sender, EventArgs e)
    {
        _questionType = "Choose Multi";
    }
}
