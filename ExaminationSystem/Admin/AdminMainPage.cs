using BL.Services;
using DAL.ExaminationnContext;
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

namespace ExaminationSystem.Admin;
public partial class AdminMainPage : Form
{
    private User _user;
    public AdminMainPage(User user)
    {
        _user = user;
        InitializeComponent();
    }

    private void lbWelcome_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void AdminMainPage_Load(object sender, EventArgs e)
    {
        lbAdminName.Text = _user.FullName;
    }

    private void btnLogou_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to logout?",
                                     "Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);


        if (result == DialogResult.Yes)
        {
            this.Hide();

            var loginForm = new LoginForm(new AuthenticationService(new ExaminationContext()));

            loginForm.FormClosed += (s, args) => this.Close();

            loginForm.Show();
        }
    }

    private void btnMngSubject_Click(object sender, EventArgs e)
    {
        Hide();
        var mngSubject = new SubjectManagement(_user);
        mngSubject.FormClosed += (s, args) =>  this.Show() ;
        mngSubject.Show();
    }
}
