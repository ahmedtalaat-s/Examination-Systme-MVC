using BL.Services;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystem.Instructor
{
    public partial class QuestionList : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ITeacher _context;
        private readonly User _user;
        private readonly Exam _exam;

        public bool backPressed = false;

        public QuestionList(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
        {
            _context = context;
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _user = user;
            _exam = exam;
        }

        private void QuestionList_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            var questions = _context.GetAllQuestion(_exam.ExamId);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Question Type column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "QusetionType",
                HeaderText = "Question Type",
                Width = 150
            });

            // Body column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Body",
                HeaderText = "Question Text",
                Width = 350
            });

            // Marks column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Marks",
                HeaderText = "Marks",
                Width = 80
            });

            // Delete button column
            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(deleteButton);

            dataGridView1.DataSource = questions.ToList();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Styling
            dataGridView1.ReadOnly = true;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col is DataGridViewButtonColumn)
                    col.ReadOnly = false;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var selectedQuestion = dataGridView1.Rows[e.RowIndex].DataBoundItem as Questions;
            if (selectedQuestion == null)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this question?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _context.DeleteQuestion(selectedQuestion.QuestionsId);
                    LoadQuestion();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ✅ Open "Choose Question Type" form to add question
            var addQuestion = ActivatorUtilities.CreateInstance<ChoseQuestionType>(
                _serviceProvider, _context, _serviceProvider, _user, _exam);

            addQuestion.Owner = this;
            addQuestion.FormClosed += (s, args) => this.LoadQuestion();
            addQuestion.FormClosed += (s, args) => this.Show();
            addQuestion.ShowDialog();
        }
    }
}
