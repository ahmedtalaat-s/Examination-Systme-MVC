using BL.Contracts;
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
using System.Xml.Linq;

namespace ExaminationSystem.Admin;
public partial class AddUser : Form
{
    private readonly IAdmin _context;
    private readonly IServiceProvider _serviceProvider;
    public bool backPressed = false;

    public AddUser(IAdmin context, IServiceProvider serviceProvider)
    {
        _context = context;
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private void AddUser_Load(object sender, EventArgs e)
    {
        cbRole.Items.AddRange(new string[] { "instructor", "student" });
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        //render combobox subjects
        List<Subject> subjects = _context.GetAllSubjects();
        cbsubjects.DropDownStyle = ComboBoxStyle.DropDownList;
        dgvSubjects.AllowUserToAddRows = false;
        // ✅ Bind ComboBox
        cbsubjects.DataSource = subjects;
        cbsubjects.DisplayMember = "SubjectName"; // what user sees
        cbsubjects.ValueMember = "SubjectId";     // the actual ID

        // ✅ Setup DataGridView
        dgvSubjects.AutoGenerateColumns = false;
        dgvSubjects.Columns.Clear();

        // Hidden ID column
        dgvSubjects.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "SubjectId",
            HeaderText = "ID",
            Visible = false // hide from user
        });

        // Visible name column
        dgvSubjects.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "SubjectName",
            HeaderText = "Subject Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });

        // Delete button column
        var btnDelete = new DataGridViewButtonColumn
        {
            HeaderText = "Action",
            Text = "Delete",
            UseColumnTextForButtonValue = true
        };
        dgvSubjects.Columns.Add(btnDelete);

        dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSubjects.ReadOnly = true;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }

    private void btnAddStudent_Click(object sender, EventArgs e)
    {
        try
        {

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbRole.Focus();
                return;
            }
            if (dgvSubjects.Rows.Count == 0)
            {
                MessageBox.Show("Please select at least one subject.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbsubjects.Focus();
                return;
            }
            var newuser = new User
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = cbRole.SelectedItem.ToString()
            };
            // 2️⃣ نضيف الـ Subject في الـ Database
            User registeredUser =  _context.AddUser(newuser);
            _context.AddSubjectsForUser(GetSelectedSubjectIds(),registeredUser);

            MessageBox.Show("user added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cbRole.Items.Clear();
            backPressed = true;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding subject: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // If Delete button clicked
        if (e.ColumnIndex == 2 && e.RowIndex >= 0)
        {
            string subjectName = dgvSubjects.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
            var confirm = MessageBox.Show($"Are you sure you want to remove '{subjectName}'?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                dgvSubjects.Rows.RemoveAt(e.RowIndex);
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (cbsubjects.SelectedItem == null)
        {
            MessageBox.Show("Please select a subject first.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int selectedId = (int)cbsubjects.SelectedValue;
        string selectedName = cbsubjects.Text;

        // 🔒 Prevent duplicates
        foreach (DataGridViewRow row in dgvSubjects.Rows)
        {
            if ((int)row.Cells["SubjectId"].Value == selectedId)
            {
                MessageBox.Show("This subject is already added.", "Duplicate Subject",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        // ✅ Add to grid
        dgvSubjects.Rows.Add(selectedId, selectedName);
    }

    public List<int> GetSelectedSubjectIds()
    {
        List<int> ids = new List<int>();
        foreach (DataGridViewRow row in dgvSubjects.Rows)
        {
            ids.Add((int)row.Cells["SubjectId"].Value);
        }
        return ids;
    }
}
