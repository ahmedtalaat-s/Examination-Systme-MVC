using BL.Contracts;
using BL.Services;
using Domains;
using ExaminationSystem.Admin;
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

namespace ExaminationSystem.Instructor
{

    public partial class ExamList : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly ITeacher _context;
        private readonly User _user;
        public bool backPressed = false;

        public ExamList(ITeacher context, IServiceProvider serviceProvider, User user)
        {
            _context = context;
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _user = user;
        }

        private void ExamList_Load(object sender, EventArgs e)
        {
            LoadExams();
        }
        private void LoadExams()
        {
            var exams = _context.GetAllExams(_user.UserId);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // ExamName
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExamName",
                HeaderText = "Exam Name",
                Width = 150
            });

            // Status
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            // Subject
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subject",
                Width = 150,
                Name = "SubjectName"
            });

            // ExamType
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExamType",
                HeaderText = "Exam Type",
                Width = 100
            });

            // Edit Button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(editButton);

            // Delete Button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(deleteButton);

            // 🔹 أهم خطوة: ربط الـ DataSource
            dataGridView1.DataSource = exams.ToList();

            // 🔹 بعد الربط نملأ عمود الـ Subject يدوي
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var exam = row.DataBoundItem as Exam;
                if (exam != null && exam.Subject != null)
                {
                    row.Cells["SubjectName"].Value = exam.Subject.SubjectName;
                }
            }

            dataGridView1.ReadOnly = true;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col is DataGridViewButtonColumn)
                {
                    col.ReadOnly = false;
                }
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addExam = ActivatorUtilities.CreateInstance<AddExam>(_serviceProvider,_user);
            addExam.Owner = this;
            addExam.FormClosed += (s, args) => this.LoadUsers();
            addExam.ShowDialog();
        }

        private void LoadUsers()
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }
    }
}
