using BL.Contracts;
using BL.Services;
using Domains;
using Microsoft.EntityFrameworkCore;
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

namespace ExaminationSystem.Student
{
    public partial class StudentPracriceExam : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IStudent _context;
        private readonly User _user;
        public bool backPressed = false;

        public StudentPracriceExam(IStudent context, IServiceProvider serviceProvider, User user)
        {
            _context = context;
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _user = user;
        }
        private void StudentPracriceExam_Load(object sender, EventArgs e)
        {

            LoadSubjects();
            LoadExams();
        }
        private void LoadSubjects()
        {
            var subjects = _context.GetStudentSubjects(_user.UserId);
            // Create "All Subjects" option
            var allOption = new Subject { SubjectId = 0, SubjectName = "All Subjects" };

            // Insert it at the top
            subjects.Insert(0, allOption);
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectId";
            cmbSubjects.DataSource = subjects;
            cmbSubjects.SelectedIndex = 0;
        }

        private void LoadExams(int subjectId = 0)
        {
            var allExams = _context.GetAvailableExams(_user.UserId, "practise");

            var filtered = subjectId == 0
                ? allExams
                : allExams.Where(e => e.SubjectId == subjectId).ToList();

            dgvExams.Columns.Clear(); // clear old columns to avoid duplicates

            // Prepare data with all needed fields (keep ExamId for later use)
            var examList = filtered.Select(e => new
            {
                e.ExamId,
                e.ExamName,
                TeacherName = e.User != null ? e.User.FullName : "N/A",
                SubjectName = e.Subject != null ? e.Subject.SubjectName : "N/A"
            }).ToList();

            dgvExams.DataSource = examList;
            dgvExams.Columns["ExamId"].Visible = false;
            // Beautify grid
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExams.ReadOnly = true;

            // Update column headers
            dgvExams.Columns["ExamName"].HeaderText = "Exam Name";
            dgvExams.Columns["TeacherName"].HeaderText = "Teacher";
            dgvExams.Columns["SubjectName"].HeaderText = "Subject";

            // ✅ Add “Take Exam” Button column
            DataGridViewButtonColumn takeExamBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "Take Exam",
                UseColumnTextForButtonValue = true,
                Width = 120,
                Name = "TakeExam"
            };
            dgvExams.Columns.Add(takeExamBtn);
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubjects.SelectedValue is int subjectId)
                LoadExams(subjectId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }

        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Make sure it's the button column
            if (dgvExams.Columns[e.ColumnIndex] is DataGridViewButtonColumn
                && dgvExams.Columns[e.ColumnIndex].Name == "TakeExam")
            {
                // Get the ExamId of the clicked row
                int examId = Convert.ToInt32(dgvExams.Rows[e.RowIndex].Cells["ExamId"].Value);

                // Get the exam entity from DB
                var exam = _context.GetAvailableExams(_user.UserId, "practise")
                                   .FirstOrDefault(ex => ex.ExamId == examId);

                if (exam == null)
                {
                    MessageBox.Show("Unable to load exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Hide();

                var takeExamForm = ActivatorUtilities.CreateInstance<TakeExamForm>(_serviceProvider, exam, _user);
                takeExamForm.Owner = this;
                takeExamForm.FormClosed += (s, args) => this.Show();
                takeExamForm.Show();
            }
        }
    }
}
