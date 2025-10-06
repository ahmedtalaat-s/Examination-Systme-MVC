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
}
