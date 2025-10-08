using BL.Contracts;
using BL.Services;
using Domains;
using System;
using System.Windows.Forms;

namespace ExaminationSystem.Instructor
{
    public partial class EditExam : Form
    {
        private readonly ITeacher _teacher;
        private Exam _exam;
        private readonly User _user;

        public EditExam(ITeacher teacher, Exam exam, User user)
        {
            InitializeComponent();
            _teacher = teacher;
            _exam = exam;
            _user = user;
        }

        private void EditExam_Load(object sender, EventArgs e)
        {
            // تحميل البيانات داخل الـ TextBoxes
            txtExamName.Text = _exam.ExamName;
            txtDuration.Text = _exam.Duration.ToString();
            comboBox1.Text = _exam.ExamType;
            comboBox2.DataSource = Enum.GetValues(typeof(Status));
            comboBox2.SelectedItem = _exam.Status;
            //List<Subject> subjects = _teacher.GetInstructorSubjects(_user.UserId);
            var subjects = _teacher.GetInstructorSubjects(_user.UserId);
            comboBox3.DataSource = subjects;
            comboBox3.DisplayMember = "SubjectName";
            comboBox3.ValueMember = "SubjectId";
            comboBox3.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // تحديث القيم من الفورم
                _exam.ExamName = txtExamName.Text;
                _exam.Duration = int.Parse(txtDuration.Text);
                _exam.ExamType = comboBox1.Text;
                _exam.Status = (Status)comboBox2.SelectedItem;

                _teacher.EditExam(_exam);

                MessageBox.Show("Exam updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating exam: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
