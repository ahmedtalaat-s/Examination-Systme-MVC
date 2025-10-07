using BL.Contracts;
using Domains;
using Microsoft.EntityFrameworkCore;
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
    private IAdmin _context;
    private IServiceProvider _serviceProvider;
    public bool backPressed = false;

    public SubjectManagement(User user, IServiceProvider serviceProvider,IAdmin context)
    {
        _user = user;
        _serviceProvider = serviceProvider;
        _context = context;
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
        LoadSubjects();
    }

    private void LoadSubjects()
    {
        var subjects = _context.GetAllSubjects();

        // لو رجعت List، نقدر نربطها مباشرة بالجريد
        dataGridView1.DataSource = subjects;

        // تعديل شكل الأعمدة
        dataGridView1.Columns["SubjectId"].HeaderText = "ID";
        dataGridView1.Columns["SubjectName"].HeaderText = "Subject Name";

        // خلي الجريد ReadOnly
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var addSubject = ActivatorUtilities.CreateInstance<AddSubject>(_serviceProvider);
        addSubject.Owner = this;
        addSubject.FormClosed +=(s,args)=> LoadSubjects();
        addSubject.ShowDialog();
    }

    
}
