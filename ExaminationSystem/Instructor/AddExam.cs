//using BL.Contracts;
//using BL.Services;
//using Domains;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace ExaminationSystem.Instructor;
//public partial class AddExam : Form
//{
//    private readonly ITeacher _teacher;

//    public AddExam(ITeacher teacher)
//    {
//        InitializeComponent();
//        _teacher = teacher;
//    }

//    private void AddExam_Load(object sender, EventArgs e)
//    {

//    }

//    private void label4_Click(object sender, EventArgs e)
//    {

//    }

//    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//    {

//    }

//    private void btnSave_Click(object sender, EventArgs e)
//    {
//        // ✅ 1️⃣ التحقق من القيم المدخلة
//        if (string.IsNullOrWhiteSpace(txtExamName.Text))
//        {
//            MessageBox.Show("Please enter the exam name.", "Validation Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            return;
//        }

//        if (comboBoxSubject.SelectedItem == null)
//        {
//            MessageBox.Show("Please select a subject.", "Validation Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            return;
//        }

//        if (comboBoxType.SelectedItem == null)
//        {
//            MessageBox.Show("Please select exam type.", "Validation Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            return;
//        }

//        if (comboBoxStatus.SelectedItem == null)
//        {
//            MessageBox.Show("Please select exam status.", "Validation Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            return;
//        }

//        if (!int.TryParse(txtDuration.Text, out int duration) || duration <= 0)
//        {
//            MessageBox.Show("Please enter a valid duration in minutes.", "Validation Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            return;
//        }

//        // ✅ 2️⃣ تكوين كائن الـ Exam
//        var newExam = new Exam
//        {
//            ExamName = txtExamName.Text.Trim(),
//            Duration = duration,
//            ExamType = comboBox1.SelectedItem.ToString(),
//            Status = (Status)Enum.Parse(typeof(Status), comboBox2.SelectedItem.ToString());
//            StartTime = dateTimePickerStartTime.Value,
//            SubjectId = (int)comboBoxSubject.SelectedValue,
//            UserId = CurrentInstructorId // 🔸 لو عندك الـ ID بتاع المدرس الحالي
//        };

//        try
//        {
//            // ✅ 3️⃣ نضيف الـ Exam في الـ Database عبر الـ BL
//            _teacher.CreateExam(newExam);

//            MessageBox.Show("Exam added successfully!", "Success",
//                            MessageBoxButtons.OK, MessageBoxIcon.Information);

//            // ✅ 4️⃣ تنظيف الحقول بعد الإضافة
//            txtExamName.Clear();
//            txtDuration.Clear();
//            comboBoxType.SelectedIndex = -1;
//            comboBoxStatus.SelectedIndex = -1;
//            comboBoxSubject.SelectedIndex = -1;
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show($"Error adding exam: {ex.Message}", "Error",
//                            MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//    }

//}
