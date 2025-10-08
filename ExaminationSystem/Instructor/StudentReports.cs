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
public partial class StudentReports : Form
{
    private readonly ITeacher _teacher;
    private readonly User _user;
    public bool backPressed = false;
    public StudentReports(ITeacher teacher, User user)
    {
        _teacher = teacher;
        _user = user;
        InitializeComponent();
    }



    private void lbStudentReport_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void StudentReports_Load(object sender, EventArgs e)
    {
        LoadReports();
    }

    private void LoadReports()
    {
        var reports = _teacher.GetInstructorExamResults(_user.UserId);

        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.Columns.Clear();

        // Exam Name
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "ExamName",
            HeaderText = "Exam Name",
            Width = 150
        });

        // Student Name
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "StudentName",
            HeaderText = "Student Name",
            Width = 150
        });

        // Subject Name
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "SubjectName",
            HeaderText = "Subject",
            Width = 150
        });

        // Score
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Score",
            HeaderText = "Score",
            Width = 100
        });

        // 🔹 ربط البيانات بالـ DataGridView
        dataGridView1.DataSource = reports;

        // 🔹 تنسيق شكلي بسيط
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }
}
