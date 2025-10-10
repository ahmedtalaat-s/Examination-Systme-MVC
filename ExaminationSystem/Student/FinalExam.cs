using BL.Contracts;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ExaminationSystem.Student
{
    public partial class FinalExam : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IStudent _context;
        private readonly User _user;

        private List<Exam> _exams = new List<Exam>();
        private readonly HashSet<int> _notifiedExamIds = new HashSet<int>();

        private Timer _refreshTimer; // updates countdown
        private Timer _notifyTimer;  // alerts about upcoming exams

        public bool backPressed = false;

        public FinalExam(IStudent context, IServiceProvider serviceProvider, User user)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            _user = user;
            InitializeComponent();
        }

        private void StudentFinalExamList_Load(object sender, EventArgs e)
        {
            LoadExams();

            // Timer to update countdown every 1s
            _refreshTimer = new Timer { Interval = 1000 };
            _refreshTimer.Tick += RefreshTimer_Tick;
            _refreshTimer.Start();

            // Timer to check upcoming exams every 30s
            _notifyTimer = new Timer { Interval = 30_000 };
            _notifyTimer.Tick += NotifyTimer_Tick;
            _notifyTimer.Start();

            dgvExams.CellContentClick -= DgvExams_CellContentClick;
            dgvExams.CellContentClick += DgvExams_CellContentClick;
        }

        private void LoadExams(int subjectId = 0)
        {
            var available = _context.GetAvailableExams(_user.UserId, "final") ?? new List<Exam>();
            _exams = (subjectId == 0) ? available : available.Where(e => e.SubjectId == subjectId).ToList();

            var rows = _exams.Select(e => new
            {
                e.ExamId,
                e.ExamName,
                SubjectName = e.Subject?.SubjectName ?? "N/A",
                TeacherName = e.User?.FullName ?? "N/A",
                StartTime = e.StartTime,
                e.Duration,
                Remaining = GetRemainingText(e)
            }).ToList();

            dgvExams.Columns.Clear();
            dgvExams.DataSource = rows;

            if (dgvExams.Columns["ExamId"] != null)
                dgvExams.Columns["ExamId"].Visible = false;

            if (dgvExams.Columns["ExamName"] != null) dgvExams.Columns["ExamName"].HeaderText = "Exam Name";
            if (dgvExams.Columns["TeacherName"] != null) dgvExams.Columns["TeacherName"].HeaderText = "Teacher";
            if (dgvExams.Columns["SubjectName"] != null) dgvExams.Columns["SubjectName"].HeaderText = "Subject";
            if (dgvExams.Columns["StartTime"] != null)
            {
                dgvExams.Columns["StartTime"].HeaderText = "Start Time";
                dgvExams.Columns["StartTime"].DefaultCellStyle.Format = "g";
            }
            if (dgvExams.Columns["Duration"] != null)
                dgvExams.Columns["Duration"].HeaderText = "Duration (Minutes)";
            if (dgvExams.Columns["Remaining"] != null)
                dgvExams.Columns["Remaining"].HeaderText = "Remaining";

            // Add “Take Exam” button
            var takeCol = new DataGridViewButtonColumn
            {
                Name = "TakeExam",
                HeaderText = "Action",
                Text = "Take Exam",
                UseColumnTextForButtonValue = true,
                Width = 110
            };
            dgvExams.Columns.Add(takeCol);

            dgvExams.ReadOnly = true;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvExams.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        // ✅ Updates countdown each second
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("show","show");
        }

        // ✅ Checks for upcoming exams (within 5 min)
        private void NotifyTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            foreach (var exam in _exams)
            {
                var diff = (exam.StartTime - now).TotalMinutes;

                if (diff > 0 && diff <= 5 && !_notifiedExamIds.Contains(exam.ExamId))
                {
                    _notifiedExamIds.Add(exam.ExamId);

                    string msg = $"Exam '{exam.ExamName}' ({exam.Subject?.SubjectName ?? "N/A"}) starts in {Math.Ceiling(diff)} minute(s).";
                    Task.Run(() =>
                    {
                        MessageBox.Show(msg, "Upcoming Exam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
            }
        }

        private string GetRemainingText(Exam exam)
        {
            var now = DateTime.Now;
            var start = exam.StartTime;
            var end = start.AddMinutes(exam.Duration);

            if (now < start)
            {
                var ts = start - now;
                return $"Starts in {FormatTimeSpanShort(ts)}";
            }
            if (now >= start && now <= end)
            {
                var ts = end - now;
                return $"{FormatTimeSpanShort(ts)} left";
            }
            return "Ended";
        }

        private static string FormatTimeSpanShort(TimeSpan ts)
        {
            if (ts.TotalHours >= 1)
                return $"{(int)ts.TotalHours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}";
            return $"{ts.Minutes:D2}:{ts.Seconds:D2}";
        }

        // ✅ Handles the “Take Exam” button
        private void DgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!(dgvExams.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;
            if (dgvExams.Columns[e.ColumnIndex].Name != "TakeExam") return;

            var row = dgvExams.Rows[e.RowIndex];
            if (row.Cells["ExamId"]?.Value == null) return;
            int examId = Convert.ToInt32(row.Cells["ExamId"].Value);

            var exam = _exams.FirstOrDefault(x => x.ExamId == examId);
            if (exam == null) return;

            var now = DateTime.Now;
            var start = exam.StartTime;
            var end = start.AddMinutes(exam.Duration);

            if (now < start)
            {
                MessageBox.Show($"This exam hasn't started yet. Starts at {start:g}.",
                    "Not Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (now > end)
            {
                MessageBox.Show("This exam has already ended.",
                    "Exam Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hide();
            var takeForm = ActivatorUtilities.CreateInstance<TakeFinalExamForm>(_serviceProvider, exam, _user);
            takeForm.Owner = this;
            takeForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadExams();
            };
            takeForm.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            _refreshTimer?.Stop();
            _notifyTimer?.Stop();
            backPressed = true;
            Close();
        }
    }
}
