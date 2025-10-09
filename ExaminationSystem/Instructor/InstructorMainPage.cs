using BL;
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

namespace ExaminationSystem.Instructor;
public partial class InstructorMainPage : Form
{
    private User _user;
    private readonly IServiceProvider _serviceProvider;
    private readonly ITeacher _context;

    public InstructorMainPage(IServiceProvider serviceProvider, ITeacher context, User user)
    {
        _context = context;
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        _user = user;
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void lbWelcome_Click(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void InstructorMainPage_Load(object sender, EventArgs e)
    {
        label1.Text = _user.FullName;
    }

    private void btnLougout1_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
              "Are you sure you want to logout?",
              "Logout",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            Hide();

            // إنشاء login form من خلال DI
            var loginForm = ActivatorUtilities.CreateInstance<LoginForm>(_serviceProvider);

            // لما تتقفل صفحة اللوجن، تتقفل الفورم دي كمان
            loginForm.FormClosed += (s, args) => Close();

            loginForm.Show();
        }
    }

    private void btnMngExam_Click(object sender, EventArgs e)
    {
        Hide();
        var studentreports = ActivatorUtilities.CreateInstance<ExamList>(_serviceProvider, _user);
        studentreports.Owner = this;
        studentreports.FormClosed += (s, args) =>
        {
            if (!studentreports.backPressed)
            {
                Application.Exit(); // close entire app
            }
            else
            {
                // show parent again (Back button pressed)
                this.Show();
            }
        };
        studentreports.Show();
    }

    private void btnMngStud_Click(object sender, EventArgs e)
    {
        Hide();

        var studentreports = ActivatorUtilities.CreateInstance<StudentReports>(_serviceProvider, _user);
        studentreports.Owner = this;
        studentreports.FormClosed += (s, args) =>
        {
            if (!studentreports.backPressed)
            {
                Application.Exit(); // close entire app
            }
            else
            {
                // show parent again (Back button pressed)
                this.Show();
            }
        };
        studentreports.Show();
    }
}
