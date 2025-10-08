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

    public AddExam(ITeacher teacher)
    {
        InitializeComponent();
        _teacher = teacher;
    }

    private void AddExam_Load(object sender, EventArgs e)
    {

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
        if (comboBoxSubject.SelectedValue == null)
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
        if (string.IsNullOrWhiteSpace(txtExamType.Text))
        {
            MessageBox.Show("Please enter exam type.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // ✅ التحقق من الـ Status
        if (comboBoxStatus.SelectedItem == null)
        {
            MessageBox.Show("Please select exam status.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // 🧠 تحويل القيمة من ComboBox إلى Enum
            Status examStatus = (Status)Enum.Parse(typeof(Status), comboBoxStatus.SelectedItem.ToString());

            var newExam = new Exam
            {
                ExamName = txtExamName.Text.Trim(),
                Duration = duration,
                ExamType = txtExamType.Text.Trim(),
                StartTime = dateTimePickerStartTime.Value,
                Status = examStatus,
                SubjectId = (int)comboBoxSubject.SelectedValue,
                UserId = CurrentInstructorId // لو عندك متغير يمثل المدرس الحالي
            };

            // 🧩 إضافة الامتحان
            _teacher.CreateExam(newExam);

            MessageBox.Show("Exam added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ تنظيف الحقول
            txtExamName.Clear();
            txtDuration.Clear();
            txtExamType.Clear();
            comboBoxSubject.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding exam: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
