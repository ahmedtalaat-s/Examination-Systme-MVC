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
public partial class EditSubject : Form
{
    private readonly IAdmin _context;
    private Subject _subject;

    public EditSubject(IAdmin context, Subject subject)
    {
        _context = context;
        _subject = subject;
        InitializeComponent();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            _subject.SubjectName = btnEdit.Text.Trim();

            if (string.IsNullOrWhiteSpace(_subject.SubjectName))
            {
                MessageBox.Show("Please enter a subject name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _context.UpdateSubject(_subject);
            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {

    }

       

        private void EditSubject_Load(object sender, EventArgs e)
        {
        btnBack.Text = _subject.SubjectName;
        }




    }

