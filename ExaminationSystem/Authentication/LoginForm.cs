using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Services;
using DAL.ExaminationnContext;
using ExaminationSystem.Instructor;
using ExaminationSystem.Student;

namespace ExaminationSystem.Admin;
public partial class LoginForm : Form
{
    private readonly IAuthentications _context;
    public LoginForm(IAuthentications context)
    {
        _context = context;
        InitializeComponent();

    }
    public LoginForm()
    {
        InitializeComponent();
    }

    private void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
       var user= _context.login(txtEmail.Text, txtPassword.Text);
        if (user != null) {
            Hide();
            if (user.Role.ToLower() == "admin")
            {
                var admindashboard = new AdminMainPage(user);
                admindashboard.Show();
                admindashboard.FormClosed += (s, args) => this.Close();

            }
            else if (user.Role.ToLower() == "admin")
            {
                var instructordashboard = new InstructorMainPage(user);
                instructordashboard.Show();
                instructordashboard.FormClosed += (s, args) => this.Close();
            }
            else
            {
                var studentdashboard = new StudentMainPage(user);
                studentdashboard.Show();
                studentdashboard.FormClosed += (s, args) => this.Close();
            }
        }
        else
        {
            MessageBox.Show("Login faild","Failer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
