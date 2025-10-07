using BL.Services;
using DAL.ExaminationnContext;
using ExaminationSystem.Instructor;
using ExaminationSystem.Student;
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

namespace ExaminationSystem.Admin;
public partial class LoginForm : Form
{
    private readonly IAuthentications _context;
    private readonly IServiceProvider _serviceProvider;
    public LoginForm(IAuthentications context, IServiceProvider serviceProvider)
    {
        _context = context;
        _serviceProvider = serviceProvider;
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
                var adminDashboard = ActivatorUtilities.CreateInstance<AdminMainPage>(_serviceProvider, user);
                adminDashboard.Show();
                adminDashboard.FormClosed += (s, args) => this.Close();

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
