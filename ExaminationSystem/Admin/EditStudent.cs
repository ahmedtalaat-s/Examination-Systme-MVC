using BL.Contracts;
using Domains;
using System.Data;

namespace ExaminationSystem.Admin;
public partial class EditStudent : Form
{
    private readonly IAdmin _context;
    private User _user;

    public EditStudent(IAdmin context, User user)
    {
        _context = context;
        _user = user;
        InitializeComponent();
    }

    private void btnEditStudent_Click(object sender, EventArgs e)
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
            _user.FullName = txtFullName.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.Password = txtPassword.Text.Trim();
            _user.Role = cbRole.SelectedItem.ToString();

            _context.UpdateUser(_user);
            _context.UpdateUserSubjects(_user,GetSelectedSubjectIds());
            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating User: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void EditStudent_Load(object sender, EventArgs e)
    {
        txtFullName.Text = _user.FullName;
        txtEmail.Text = _user.Email;
        txtPassword.Text = _user.Password;

        cbRole.Items.Add("instructor");
        cbRole.Items.Add("student");

        cbRole.SelectedItem = _user.Role;

        //subjects
        List<Subject> subjects = _context.GetAllSubjects();
        cbsubjects.DropDownStyle = ComboBoxStyle.DropDownList;
        dgvSubjects.AllowUserToAddRows = false;
        // ✅ Bind ComboBox
        cbsubjects.DataSource = subjects;
        cbsubjects.DisplayMember = "SubjectName"; // what user sees
        cbsubjects.ValueMember = "SubjectId";     // the actual ID

        // ✅ Setup DataGridView
        dgvSubjects.AutoGenerateColumns = false;
        //dgvSubjects.Columns.Clear();

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
        var _subjects = _user.UserSubjects.Select(us => new
        {
            SubjectId = us.SubjectId,
            SubjectName = us.Subject.SubjectName
        })
    .ToList();
        foreach (var subject in _subjects)
        {
            dgvSubjects.Rows.Add(subject.SubjectId, subject.SubjectName);
        }
        dgvSubjects.ReadOnly = true;

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
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

    private void button2_Click(object sender, EventArgs e)
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
