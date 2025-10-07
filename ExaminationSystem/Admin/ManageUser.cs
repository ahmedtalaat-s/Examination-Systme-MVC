using BL.Contracts;
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

namespace ExaminationSystem.Admin
{
    public partial class ManageUser : Form
    {
        private readonly IAdmin _context;
        private User _user;

        public ManageUser(IAdmin context, User user)
        {
            _context = context;
            InitializeComponent();
            _user = user;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            var exams = _context.GetAllUsers();

            // Make sure the DataGridView does not auto-generate columns
            lstStudent.AutoGenerateColumns = false;
            lstStudent.Columns.Clear();

            // Define columns manually

            // ExamName
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExamName",
                HeaderText = "Exam Name",
                Width = 150
            });

            // Status
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            // Subject
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Subject",
                Width = 150,
                Name = "SubjectName"
            });

            // ExamType
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
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
            lstStudent.Columns.Add(editButton);

            // Delete Button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            lstStudent.Columns.Add(deleteButton);

            // Bind data
            lstStudent.DataSource = exams;

            // Handle displaying Subject name manually
            foreach (DataGridViewRow row in lstStudent.Rows)
            {
                var exam = row.DataBoundItem as Exam;
                if (exam != null && exam.Subject != null)
                {
                    row.Cells["SubjectName"].Value = exam.Subject.SubjectName;
                }
            }

            lstStudent.ReadOnly = true;
            foreach (DataGridViewColumn col in lstStudent.Columns)
            {
                if (col is DataGridViewButtonColumn)
                {
                    col.ReadOnly = false;
                }
            }
            lstStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstStudent.EnableHeadersVisualStyles = false;
            lstStudent.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            lstStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lstStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            lstStudent.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            //// Handle button clicks

        }
    }
}
