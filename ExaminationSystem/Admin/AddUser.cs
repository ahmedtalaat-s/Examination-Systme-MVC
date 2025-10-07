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
            var newuser = new User
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = cbRole.SelectedItem.ToString()
            };
            // 2️⃣ نضيف الـ Subject في الـ Database
            _context.AddUser(newuser);

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
}
