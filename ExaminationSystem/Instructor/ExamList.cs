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

namespace ExaminationSystem.Instructor
{

    public partial class ExamList : Form
    {

        public ExamList()
        {
            InitializeComponent();
        }

        private void ExamList_Load(object sender, EventArgs e)
        {
            // Sample data to simulate database (you'll replace with _context.Exams.Include(x => x.Subject))
            var exams = new List<Exam>
    {
        new Exam { ExamId = 1, ExamName = "Math Final", ExamType = "Final", Status = Status.Pendding, Subject = new Subject{ SubjectName = "Math" } },
        new Exam { ExamId = 2, ExamName = "Physics Practice", ExamType = "Practice", Status = Status.Pendding, Subject = new Subject{ SubjectName = "Physics" } }
    };

            // Make sure the DataGridView does not auto-generate columns
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Define columns manually

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

            // Bind data
            dataGridView1.DataSource = exams;

            // Handle displaying Subject name manually
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
            //// Handle button clicks
            //dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
