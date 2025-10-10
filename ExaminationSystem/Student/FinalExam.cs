using BL.Contracts;
using Domains;
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
using Timer = System.Windows.Forms.Timer;

namespace ExaminationSystem.Student
{
    public partial class FinalExam : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly IStudent _context;
        private readonly User _user;

        private List<Exam> _exams = new List<Exam>();
        private HashSet<int> _notifiedExamIds = new HashSet<int>();

        private Timer _refreshTimer; // updates the remaining time column every second
        private Timer _notifyTimer;  // checks for upcoming exams (e.g. 5 minutes before)
        private System.Windows.Forms.Timer countdownTimer;

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

            // Refresh every second to keep remaining times live
            _refreshTimer = new Timer { Interval = 500 };
            _refreshTimer.Tick += RefreshTimer_Tick;
            _refreshTimer.Start();

            // Notify every 30 seconds (or 60s) about upcoming exams
            _notifyTimer = new Timer { Interval = 30_000 };
            _notifyTimer.Tick += NotifyTimer_Tick;
            _notifyTimer.Start();

            // Attach click handler for the TakeExam button column
            dgvExams.CellContentClick -= DgvExams_CellContentClick;
            dgvExams.CellContentClick += DgvExams_CellContentClick;
        }


        private void LoadExams(int subjectId = 0)
        {
            // fetch final exams available to this student
            var available = _context.GetAvailableExams(_user.UserId, "final") ?? new List<Exam>();

            // Optionally include navigation data (Questions/Choices) — depends on your BL implementation.
            // Filter by subject
            _exams = (subjectId == 0) ? available : available.Where(e => e.SubjectId == subjectId).ToList();

            // Build a simple data source (anonymous objects) that include fields we need
            var rows = _exams.Select(e => new
            {
                e.ExamId,
                e.ExamName,
                SubjectName = e.Subject?.SubjectName ?? "N/A",
                TeacherName = e.User?.FullName ?? "N/A",
                StartTime = e.StartTime,
                Duration = e.Duration,
                Remaining = GetRemainingText(e) // initial value; updated by timer
            }).ToList();

            dgvExams.Columns.Clear();
            dgvExams.DataSource = rows;

            // Hide exam id column (still available in data)
            if (dgvExams.Columns["ExamId"] != null)
                dgvExams.Columns["ExamId"].Visible = false;

            // Format / rename columns
            if (dgvExams.Columns["ExamName"] != null) dgvExams.Columns["ExamName"].HeaderText = "Exam Name";
            if (dgvExams.Columns["TeacherName"] != null) dgvExams.Columns["TeacherName"].HeaderText = "Teacher";
            if (dgvExams.Columns["SubjectName"] != null) dgvExams.Columns["SubjectName"].HeaderText = "Subject";
            if (dgvExams.Columns["StartTime"] != null)
            {
                dgvExams.Columns["StartTime"].HeaderText = "Start Time";
                dgvExams.Columns["StartTime"].DefaultCellStyle.Format = "g"; // general datetime
            }
            if (dgvExams.Columns["Duration"] != null) dgvExams.Columns["Duration"].HeaderText = "Duration (HR)";
            if (dgvExams.Columns["Remaining"] != null) dgvExams.Columns["Remaining"].HeaderText = "Remaining";

            // Add Take Exam button column
            var takeCol = new DataGridViewButtonColumn
            {
                Name = "TakeExam",
                HeaderText = "Action",
                Text = "Take Exam",
                UseColumnTextForButtonValue = true,
                Width = 110
            };
            dgvExams.Columns.Add(takeCol);

            // Look & feel
            dgvExams.ReadOnly = true;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvExams.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // every 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
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

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Update remaining time column for each row using stored _exams
            for (int i = 0; i < dgvExams.Rows.Count; i++)
            {
                var row = dgvExams.Rows[i];
                // get ExamId from underlying data
                if (row.Cells["ExamId"]?.Value == null) continue;
                int examId = Convert.ToInt32(row.Cells["ExamId"].Value);
                var exam = _exams.FirstOrDefault(x => x.ExamId == examId);
                if (exam == null) continue;

                string newText = GetRemainingText(exam);

                if (row.Cells["Remaining"] != null)
                    row.Cells["Remaining"].Value = newText;
            }
        }

        private void NotifyTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            foreach (var exam in _exams)
            {
                // if already started or ended ignore
                var start = exam.StartTime;
                var diff = (start - now).TotalMinutes;

                // if within 5 minutes and not yet notified and not already started
                if (diff > 0 && diff <= 5)
                {
                    if (!_notifiedExamIds.Contains(exam.ExamId))
                    {
                        _notifiedExamIds.Add(exam.ExamId);
                        // Use a non-blocking popup (MessageBox will block, but it's simplest):
                        // You can replace with a Tray/Toast implementation if you have one.
                        var msg = $"Exam '{exam.ExamName}' for '{exam.Subject?.SubjectName ?? "N/A"}' will start in {Math.Ceiling(diff)} minute(s).";
                        // show but don't block other timer updates for long
                        Task.Run(() => MessageBox.Show(msg, "Upcoming Exam", MessageBoxButtons.OK, MessageBoxIcon.Information));
                    }
                }
            }
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvExams.Rows)
            {
                if (row.Cells["StartTime"].Value is DateTime startTime &&
                    row.Cells["Duration"].Value != null)
                {
                    int duration = Convert.ToInt32(row.Cells["Duration"].Value);
                    row.Cells["Remaining"].Value = GetRemainingTimeText(startTime, duration);
                }
            }
        }
        private string GetRemainingTimeText(DateTime startTime, int durationMinutes)
        {
            var endTime = startTime.AddMinutes(durationMinutes);
            var remaining = endTime - DateTime.Now;

            if (DateTime.Now < startTime)
                return $"Starts in {remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
            else if (remaining.TotalSeconds > 0)
                return $"Time Left {remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";
            else
                return "Exam Ended";
        }

        private void DgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!(dgvExams.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;
            if (dgvExams.Columns[e.ColumnIndex].Name != "TakeExam") return;

            // get exam id
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
                MessageBox.Show($"This exam hasn't started yet. Starts at {start:g}.", "Not Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (now > end)
            {
                MessageBox.Show("This exam has already ended.", "Exam Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure exam has questions & choices loaded
            // If your IStudent.GetAvailableExams doesn't include Questions, you may need to load full exam details here.
            // Try to get a fresh version from the service if available:
            try
            {
                // If your IStudent has a method to get full exam by id, use it.
                // Otherwise we assume 'exam' already has Questions and Choices.
            }
            catch
            {
                // ignore
            }

            // Open TakeFinalExamForm
            Hide();
            var takeForm = ActivatorUtilities.CreateInstance<TakeFinalExamForm>(_serviceProvider, exam, _user);
            takeForm.Owner = this;
            takeForm.FormClosed += (s, args) =>
            {
                // stop timers when leaving? timers are owned by this form so they stay alive; re-show parent
                this.Show();
                // optionally reload to update remaining times
                LoadExams();
            };
            takeForm.Show();
        }


        private void FInalExamGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuestionLb_Click(object sender, EventArgs e)
        {
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
