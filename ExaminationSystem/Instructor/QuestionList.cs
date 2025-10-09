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
public partial class QuestionList : Form
{

    private readonly IServiceProvider _serviceProvider;

    private readonly ITeacher _context;
    private readonly User _user;
    private readonly Exam _exam;

    public bool backPressed = false;

    public QuestionList(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
    {
        _context = context;
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _user = user;
        _exam = exam;
    }

    private void QuestionList_Load(object sender, EventArgs e)
    {
        LoadQuestion();
    }
    public void LoadQuestion()
    {
        var questions = _context.GetAllQuestion(_exam.ExamId);
        dataGridView1.DataSource = questions;
    } 
    private void btnBack_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var addQuestion = ActivatorUtilities.CreateInstance<ChoseQuestionType>(_serviceProvider, _user,_exam);
        addQuestion.Owner = this;
        addQuestion.FormClosed += (s, args) => this.LoadQuestion();
        addQuestion.FormClosed += (s, args) => this.Show();
        addQuestion.ShowDialog();
    }
}
