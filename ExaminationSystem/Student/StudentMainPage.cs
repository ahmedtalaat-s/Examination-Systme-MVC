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

namespace ExaminationSystem.Student;
public partial class StudentMainPage : Form
{
    private User _user;

    public StudentMainPage(User user)
    {
        _user = user;
        InitializeComponent();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
}
