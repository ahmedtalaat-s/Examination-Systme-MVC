namespace ExaminationSystem.Student;

partial class StudentMainPage
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        btnProfile = new Button();
        btnLogout = new Button();
        label1 = new Label();
        lbWelcome = new Label();
        panel2 = new Panel();
        label2 = new Label();
        btnPracticeExam = new Button();
        btnReports = new Button();
        btnFinalExam = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
        panel1.Controls.Add(btnProfile);
        panel1.Controls.Add(btnLogout);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(lbWelcome);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(16, 10, 16, 10);
        panel1.Size = new Size(882, 70);
        panel1.TabIndex = 0;
        // 
        // btnProfile
        // 
        btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProfile.BackColor = SystemColors.HotTrack;
        btnProfile.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnProfile.ForeColor = SystemColors.ControlLightLight;
        btnProfile.Location = new Point(630, 20);
        btnProfile.Name = "btnProfile";
        btnProfile.Size = new Size(107, 34);
        btnProfile.TabIndex = 4;
        btnProfile.Text = "Profile";
        btnProfile.UseVisualStyleBackColor = false;
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.Location = new Point(756, 20);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(107, 34);
        btnLogout.TabIndex = 2;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        btnLogout.Click += btnLogout_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.HotTrack;
        label1.Location = new Point(193, 16);
        label1.Name = "label1";
        label1.Size = new Size(195, 38);
        label1.TabIndex = 1;
        label1.Text = "Student Name";
        label1.Click += label1_Click;
        // 
        // lbWelcome
        // 
        lbWelcome.AutoSize = true;
        lbWelcome.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbWelcome.ForeColor = SystemColors.InactiveCaptionText;
        lbWelcome.Location = new Point(12, 10);
        lbWelcome.Name = "lbWelcome";
        lbWelcome.Size = new Size(196, 46);
        lbWelcome.TabIndex = 0;
        lbWelcome.Text = "Welcome , ";
        // 
        // panel2
        // 
        panel2.Controls.Add(label2);
        panel2.Controls.Add(btnPracticeExam);
        panel2.Controls.Add(btnReports);
        panel2.Controls.Add(btnFinalExam);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 70);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(32);
        panel2.Size = new Size(882, 483);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = SystemColors.HotTrack;
        label2.Font = new Font("Segoe UI Symbol", 9F);
        label2.ForeColor = Color.Snow;
        label2.Location = new Point(342, 264);
        label2.Name = "label2";
        label2.Size = new Size(208, 20);
        label2.TabIndex = 3;
        label2.Text = "View and export exam reports";
        // 
        // btnPracticeExam
        // 
        btnPracticeExam.Location = new Point(44, 184);
        btnPracticeExam.Name = "btnPracticeExam";
        btnPracticeExam.Size = new Size(254, 121);
        btnPracticeExam.TabIndex = 2;
        btnPracticeExam.Text = "Practice Exams";
        btnPracticeExam.UseVisualStyleBackColor = true;
        btnPracticeExam.Click += btnPracticeExam_Click;
        // 
        // btnReports
        // 
        btnReports.BackColor = SystemColors.HotTrack;
        btnReports.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnReports.ForeColor = SystemColors.ControlLightLight;
        btnReports.Location = new Point(318, 184);
        btnReports.Name = "btnReports";
        btnReports.Size = new Size(254, 121);
        btnReports.TabIndex = 1;
        btnReports.Text = "Reports";
        btnReports.UseVisualStyleBackColor = false;
        btnReports.Click += btnReports_Click;
        // 
        // btnFinalExam
        // 
        btnFinalExam.Location = new Point(592, 184);
        btnFinalExam.Name = "btnFinalExam";
        btnFinalExam.Size = new Size(254, 121);
        btnFinalExam.TabIndex = 0;
        btnFinalExam.Text = "Final Exams";
        btnFinalExam.UseVisualStyleBackColor = true;
        btnFinalExam.Click += btnFinalExam_Click;
        // 
        // StudentMainPage
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(882, 553);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "StudentMainPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Page";
        Load += StudentMainPage_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lbWelcome;
    private Label label1;
    private Button btnLogout;
    private Panel panel2;
    private Button btnPracticeExam;
    private Button btnReports;
    private Button btnFinalExam;
    private Label label2;
    private Button btnProfile;
}