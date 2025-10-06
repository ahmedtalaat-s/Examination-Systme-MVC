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
public partial class SubjectManagement : Form
{
    private User _user;
    
    public SubjectManagement(User user)
    {
        _user = user;
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}
