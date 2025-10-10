using BL.Contracts;
using BL.Services;
using Domains;
using ExaminationSystem.Admin;
using ExaminationSystem.Instructor;
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

namespace ExaminationSystem.Student;
public partial class StudentMainPage : Form
{
    private User _user;
    private readonly IServiceProvider _serviceProvider;
    private readonly IStudent _context;
    private System.Windows.Forms.Timer notificationTimer;
    private NotifyIcon notifyIcon;

    public StudentMainPage(IServiceProvider serviceProvider, IStudent context, User user)
    {
        _context = context;
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        _user = user;
        InitializeComponent();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnPracticeExam_Click(object sender, EventArgs e)
    {
        Hide();
        var practiselist = ActivatorUtilities.CreateInstance<StudentPracriceExam>(_serviceProvider, _user);
        practiselist.Owner = this;
        practiselist.FormClosed += (s, args) =>
        {
            if (!practiselist.backPressed)
            {
                Application.Exit(); // close entire app
            }
            else
            {
                // show parent again (Back button pressed)
                this.Show();
            }
        };
        practiselist.Show();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
              "Are you sure you want to logout?",
              "Logout",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            Hide();

            // إنشاء login form من خلال DI
            var loginForm = ActivatorUtilities.CreateInstance<LoginForm>(_serviceProvider);

            // لما تتقفل صفحة اللوجن، تتقفل الفورم دي كمان
            loginForm.FormClosed += (s, args) => Close();

            loginForm.Show();
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void StudentMainPage_Load(object sender, EventArgs e)
    {
        label1.Text = _user.FullName;
        SetupNotificationSystem();
    }

    private void btnFinalExam_Click(object sender, EventArgs e)
    {
        Hide();
        var finalList = ActivatorUtilities.CreateInstance<FinalExam>(_serviceProvider, _user);
        finalList.Owner = this;
        finalList.FormClosed += (s, args) =>
        {
            if (!finalList.backPressed)
            {
                Application.Exit(); // close entire app
            }
            else
            {
                // show parent again (Back button pressed)
                this.Show();
            }
        };
        finalList.Show();
    }

    private void SetupNotificationSystem()
    {
        // Create system tray icon
        notifyIcon = new NotifyIcon
        {
            Visible = true,
            Icon = SystemIcons.Information,
            BalloonTipTitle = "Exam Reminder"
        };

        // Set up timer
        notificationTimer = new System.Windows.Forms.Timer();
        notificationTimer.Interval = 60000; // check every 1 minute
        notificationTimer.Tick += NotificationTimer_Tick;
        notificationTimer.Start();
    }

    private void NotificationTimer_Tick(object sender, EventArgs e)
    {
        try
        {
            var upcomingExams = _context.GetAvailableExams(_user.UserId, "final")
                .Where(ex => ex.StartTime > DateTime.Now &&
                             ex.StartTime <= DateTime.Now.AddMinutes(5)) // starts within 5 min
                .ToList();

            foreach (var exam in upcomingExams)
            {
                string msg = $"Your exam \"{exam.ExamName}\" for {exam.Subject?.SubjectName} starts at {exam.StartTime:t}";
                notifyIcon.ShowBalloonTip(5000, "Upcoming Exam", msg, ToolTipIcon.Info);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Notification check failed: " + ex.Message);
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        notifyIcon?.Dispose();
        notificationTimer?.Stop();
    }

    private void btnReports_Click(object sender, EventArgs e)
    {
        Hide();
        var reports = ActivatorUtilities.CreateInstance<StudentReport>(_serviceProvider, _user);
        reports.Owner = this;
        reports.FormClosed += (s, args) =>
        {
            if (!reports.backPressed)
            {
                Application.Exit(); // close entire app
            }
            else
            {
                // show parent again (Back button pressed)
                this.Show();
            }
        };
        reports.Show();
    }
}
