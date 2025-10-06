namespace ExaminationSystem.Admin;

partial class AdminMainPage
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
        button2 = new Button();
        btnLogout = new Button();
        lbAdminName = new Label();
        lbWelcome = new Label();
        btnMngUser = new Button();
        btnMngExam = new Button();
        btnProfilee = new Button();
        btnLogou = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
        panel1.Controls.Add(btnProfilee);
        panel1.Controls.Add(btnLogou);
        panel1.Controls.Add(btnProfile);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(btnLogout);
        panel1.Controls.Add(lbAdminName);
        panel1.Controls.Add(lbWelcome);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(16, 10, 16, 10);
        panel1.Size = new Size(882, 70);
        panel1.TabIndex = 4;
        // 
        // btnProfile
        // 
        btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProfile.BackColor = SystemColors.HotTrack;
        btnProfile.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnProfile.ForeColor = SystemColors.ControlLightLight;
        btnProfile.Location = new Point(1299, 30);
        btnProfile.Name = "btnProfile";
        btnProfile.Size = new Size(107, 34);
        btnProfile.TabIndex = 5;
        btnProfile.Text = "Profile";
        btnProfile.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.Location = new Point(1422, 30);
        button2.Name = "button2";
        button2.Size = new Size(107, 34);
        button2.TabIndex = 3;
        button2.Text = "Logout";
        button2.UseVisualStyleBackColor = true;
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.Location = new Point(2088, 40);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(107, 34);
        btnLogout.TabIndex = 2;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // lbAdminName
        // 
        lbAdminName.AutoSize = true;
        lbAdminName.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbAdminName.ForeColor = SystemColors.HotTrack;
        lbAdminName.Location = new Point(182, 20);
        lbAdminName.Name = "lbAdminName";
        lbAdminName.Size = new Size(180, 38);
        lbAdminName.TabIndex = 1;
        lbAdminName.Text = "Admin Name";
        // 
        // lbWelcome
        // 
        lbWelcome.AutoSize = true;
        lbWelcome.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbWelcome.ForeColor = SystemColors.InactiveCaptionText;
        lbWelcome.Location = new Point(7, 14);
        lbWelcome.Name = "lbWelcome";
        lbWelcome.Size = new Size(196, 46);
        lbWelcome.TabIndex = 0;
        lbWelcome.Text = "Welcome , ";
        lbWelcome.Click += lbWelcome_Click;
        // 
        // btnMngUser
        // 
        btnMngUser.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnMngUser.Location = new Point(458, 263);
        btnMngUser.Name = "btnMngUser";
        btnMngUser.Size = new Size(346, 141);
        btnMngUser.TabIndex = 6;
        btnMngUser.Text = "Manage User";
        btnMngUser.UseVisualStyleBackColor = true;
        // 
        // btnMngExam
        // 
        btnMngExam.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnMngExam.Location = new Point(62, 263);
        btnMngExam.Name = "btnMngExam";
        btnMngExam.Size = new Size(346, 141);
        btnMngExam.TabIndex = 5;
        btnMngExam.Text = "Manage Exam";
        btnMngExam.UseVisualStyleBackColor = true;
        // 
        // btnProfilee
        // 
        btnProfilee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnProfilee.BackColor = SystemColors.HotTrack;
        btnProfilee.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnProfilee.ForeColor = SystemColors.ControlLightLight;
        btnProfilee.Location = new Point(629, 23);
        btnProfilee.Name = "btnProfilee";
        btnProfilee.Size = new Size(107, 34);
        btnProfilee.TabIndex = 7;
        btnProfilee.Text = "Profile";
        btnProfilee.UseVisualStyleBackColor = false;
        // 
        // btnLogou
        // 
        btnLogou.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogou.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogou.Location = new Point(756, 23);
        btnLogou.Name = "btnLogou";
        btnLogou.Size = new Size(107, 34);
        btnLogou.TabIndex = 6;
        btnLogou.Text = "Logout";
        btnLogou.UseVisualStyleBackColor = true;
        // 
        // AdminMainPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(panel1);
        Controls.Add(btnMngUser);
        Controls.Add(btnMngExam);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "AdminMainPage";
        Text = "AdminMainPage";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button btnProfile;
    private Button button2;
    private Button btnLogout;
    private Label lbAdminName;
    private Label lbWelcome;
    private Button btnMngUser;
    private Button btnMngExam;
    private Button btnProfilee;
    private Button btnLogou;
}