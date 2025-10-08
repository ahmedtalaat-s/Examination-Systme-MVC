using BL.Contracts;
using BL.Services;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExaminationSystem.Instructor;
public partial class AddExam : Form
{
    private readonly ITeacher _teacher;
    private readonly User _user;

    public AddExam(ITeacher teacher, User user)
    {
        InitializeComponent();
        _teacher = teacher;
        _user = user;
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
        if (comboBox3.SelectedValue == null)
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
        if (string.IsNullOrWhiteSpace(comboBox1.Text))
        {
            MessageBox.Show("Please enter exam type.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من الـ Status
        if (comboBox2.SelectedItem == null)
        {
            MessageBox.Show("Please select exam status.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // 🧠 تحويل القيمة من ComboBox إلى Enum
            Domains.Status examStatus = (Domains.Status)Enum.Parse(typeof(Domains.Status), comboBox2.SelectedItem.ToString());

            var newExam = new Exam
            {
                ExamName = txtExamName.Text.Trim(),
                Duration = duration,
                ExamType = comboBox1.Text.Trim(),
                StartTime = dateTimePicker1.Value,
                Status = examStatus,
                SubjectId = (int)comboBox3.SelectedValue,
                UserId = _user.UserId,
            };

            // 🧩 إضافة الامتحان
            _teacher.CreateExam(newExam);

            MessageBox.Show("Exam added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ تنظيف الحقول
            txtExamName.Clear();
            txtDuration.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding exam: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddExam_Load(object sender, EventArgs e)
    {

    }
}
