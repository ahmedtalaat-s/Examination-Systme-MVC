using BL.Contracts;
using BL.Services;
using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExaminationSystem.Instructor;
public partial class AddExam : Form
{
    private readonly ITeacher _teacher;
    private readonly User _user;

    public AddExam(ITeacher teacher,User user)
    {
        InitializeComponent();
        _teacher = teacher;
        _user = user;
    }

    private void AddExam_Load(object sender, EventArgs e)
    {
        //load combox Type
        cbType.Items.AddRange(new string[] { "final", "practise" });
        cbType.DropDownStyle = ComboBoxStyle.DropDownList;
        //load combox Type
        cbStatus.Items.AddRange(new string[] { "Pendding", "Started", "Ending" });
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        // cb subjects
        //render combobox subjects
        List<Subject> subjects = _teacher;
        cbsubjects.DropDownStyle = ComboBoxStyle.DropDownList;
        // ✅ Bind ComboBox
        cbsubjects.DataSource = subjects;
        cbsubjects.DisplayMember = "SubjectName"; // what user sees
        cbsubjects.ValueMember = "SubjectId";     // the actual ID
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // ✅ التحقق من الاسم
        if (string.IsNullOrWhiteSpace(txtExamName.Text))
        {
            MessageBox.Show("Please enter exam name.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من الـ Subject
        if (cbsubjects.SelectedValue == null)
        {
            MessageBox.Show("Please select a subject.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من المدة
        if (!int.TryParse(txtDuration.Text, out int duration) || duration <= 0)
        {
            MessageBox.Show("Please enter a valid duration.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من نوع الامتحان
        if (string.IsNullOrWhiteSpace(cbType.Text))
        {
            MessageBox.Show("Please enter exam type.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من الـ Status
        if (cbStatus.SelectedItem == null)
        {
            MessageBox.Show("Please select exam status.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // 🧠 تحويل القيمة من ComboBox إلى Enum
            Domains.Status examStatus = (Domains.Status)Enum.Parse(typeof(Domains.Status), cbStatus.SelectedItem.ToString());

            var newExam = new Exam
            {
                ExamName = txtExamName.Text.Trim(),
                Duration = duration,
                ExamType = cbType.Text.Trim(),
                StartTime = dateTimePicker1.Value,
                Status = examStatus,
                SubjectId = (int)cbsubjects.SelectedValue,
                UserId =  _user.UserId,
            };

            // 🧩 إضافة الامتحان
            _teacher.CreateExam(newExam);

            MessageBox.Show("Exam added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ تنظيف الحقول
            txtExamName.Clear();
            txtDuration.Clear();
            cbType.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbsubjects.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding exam: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
