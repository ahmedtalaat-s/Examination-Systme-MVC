using BL.Contracts;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ExaminationSystem.Admin
{
    public partial class SubjectManagement : Form
    {
        private readonly User _user;
        private readonly IAdmin _adminService;
        private readonly IServiceProvider _serviceProvider;
        public bool backPressed = false;

        public SubjectManagement(User user, IServiceProvider serviceProvider, IAdmin adminService)
        {
            _user = user;
            _serviceProvider = serviceProvider;
            _adminService = adminService;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }

        private void SubjectManagement_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            var subjects = _adminService.GetAllSubjects();
            dataGridView1.DataSource = subjects;

            dataGridView1.Columns["SubjectName"].HeaderText = "Subject Name";

            if (dataGridView1.Columns["SubjectId"] != null)
                dataGridView1.Columns["SubjectId"].Visible = false;

            // ✅ إضافة الأزرار (Edit + Delete) لو مش موجودين
            if (!dataGridView1.Columns.Contains("EditButton"))
            {
                var editButton = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridView1.Columns.Add(editButton);
            }

            if (!dataGridView1.Columns.Contains("DeleteButton"))
            {
                var deleteButton = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridView1.Columns.Add(deleteButton);
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedSubject = (Subject)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // ✅ Edit
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    var subjectId = selectedSubject.SubjectId;
                    var subject = _adminService.GetSubjectById(subjectId);

                    if (subject != null)
                    {
                        // استخدم DI علشان تعمل instance للفورم
                        var editForm = ActivatorUtilities.CreateInstance<EditSubject>(_serviceProvider, subject);
                        editForm.FormClosed += (s, args) => LoadSubjects();
                        editForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Subject not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // ✅ Delete
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to delete '{selectedSubject.SubjectName}'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        _adminService.DeleteSubject(selectedSubject.SubjectId);
                        MessageBox.Show("Subject deleted successfully!", "Deleted",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSubjects();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addSubject = ActivatorUtilities.CreateInstance<AddSubject>(_serviceProvider);
            addSubject.Owner = this;
            addSubject.FormClosed += (s, args) => LoadSubjects();
            addSubject.ShowDialog();
        }
    }
}
