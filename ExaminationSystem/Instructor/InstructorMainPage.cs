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

namespace ExaminationSystem.Instructor;
public partial class InstructorMainPage : Form
{
    private User _user;

    public InstructorMainPage(User user)
    {
        _user = user;
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void lbWelcome_Click(object sender, EventArgs e)
    {

    }
}
