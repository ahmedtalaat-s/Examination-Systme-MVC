using BL.Contracts;
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
public partial class AddSubject : Form
{
    private readonly IAdmin _context;
    private readonly IServiceProvider _serviceProvider;

    public bool backPressed = false;

    public AddSubject(IAdmin context, IServiceProvider serviceProvider)
    {
        _context = context;
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void button1_Click(object sender, EventArgs e)
    {
       
        var newSubject = new Subject
        {
            SubjectName = txtSubject.Text  
        };

        try
        {
            
            backPressed = true;
            Close();
            // 2️⃣ نضيف الـ Subject في الـ Database
            _context.AddSubject(newSubject);

            MessageBox.Show("Subject added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            txtSubject.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding subject: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        backPressed = true;
        Close();
    }
}
