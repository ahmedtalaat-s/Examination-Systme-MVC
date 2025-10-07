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

namespace ExaminationSystem.Admin;
public partial class SubjectManagement : Form
{
    private User _user;
    private IServiceProvider _serviceProvider;
    public bool backPressed = false;

    public SubjectManagement(User user, IServiceProvider serviceProvider)
    {
        _user = user;
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }

    private void SubjectManagement_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var addSubject = ActivatorUtilities.CreateInstance<AddSubject>(_serviceProvider);
        addSubject.Owner = this;
         
        addSubject.ShowDialog();
    }
}
