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
        btnLogou = new Button();
        btnProfilee = new Button();
        lbAdminName = new Label();
        lbWelcome = new Label();
        btnMngUser = new Button();
        btnMngSubject = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
        panel1.Controls.Add(btnLogou);
        panel1.Controls.Add(btnProfilee);
        panel1.Controls.Add(lbAdminName);
        panel1.Controls.Add(lbWelcome);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(16, 10, 16, 10);
        panel1.Size = new Size(882, 70);
        panel1.TabIndex = 4;
        panel1.Paint += panel1_Paint;
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
        // lbAdminName
        // 
        lbAdminName.AutoSize = true;
        lbAdminName.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbAdminName.ForeColor = SystemColors.HotTrack;
        lbAdminName.Location = new Point(197, 23);
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
        // btnMngSubject
        // 
        btnMngSubject.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnMngSubject.Location = new Point(62, 263);
        btnMngSubject.Name = "btnMngSubject";
        btnMngSubject.Size = new Size(346, 141);
        btnMngSubject.TabIndex = 5;
        btnMngSubject.Text = "Manage Subject";
        btnMngSubject.UseVisualStyleBackColor = true;
        // 
        // AdminMainPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(panel1);
        Controls.Add(btnMngUser);
        Controls.Add(btnMngSubject);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "AdminMainPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AdminMainPage";
        Load += AdminMainPage_Load;
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
    private Button btnMngSubject;
    private Button btnProfilee;
    private Button btnLogou;
}