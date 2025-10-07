using BL.Contracts;
using Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            _user.FullName = txtFullName.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.Password = txtPassword.Text.Trim();
            _user.Role = cbRole.SelectedItem.ToString();

            _context.UpdateUser(_user);
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
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }
}
