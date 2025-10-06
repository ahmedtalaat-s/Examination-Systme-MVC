namespace ExaminationSystem.Instructor;

partial class InstructorMainPage
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
        btnLogout = new Button();
        label1 = new Label();
        lbWelcome = new Label();
        panel2 = new Panel();
        button3 = new Button();
        button1 = new Button();
        button2 = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
        panel1.Controls.Add(button2);
        panel1.Controls.Add(btnLogout);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(lbWelcome);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(16, 10, 16, 10);
        panel1.Size = new Size(882, 70);
        panel1.TabIndex = 2;
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLogout.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.Location = new Point(1422, 30);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(107, 34);
        btnLogout.TabIndex = 2;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.HotTrack;
        label1.Location = new Point(209, 26);
        label1.Name = "label1";
        label1.Size = new Size(217, 38);
        label1.TabIndex = 1;
        label1.Text = "Instructor Name";
        // 
        // lbWelcome
        // 
        lbWelcome.AutoSize = true;
        lbWelcome.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbWelcome.ForeColor = SystemColors.InactiveCaptionText;
        lbWelcome.Location = new Point(28, 20);
        lbWelcome.Name = "lbWelcome";
        lbWelcome.Size = new Size(196, 46);
        lbWelcome.TabIndex = 0;
        lbWelcome.Text = "Welcome , ";
        // 
        // panel2
        // 
        panel2.Controls.Add(button1);
        panel2.Controls.Add(button3);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(32);
        panel2.Size = new Size(882, 553);
        panel2.TabIndex = 3;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button3.Location = new Point(64, 216);
        button3.Name = "button3";
        button3.Size = new Size(346, 141);
        button3.TabIndex = 2;
        button3.Text = "Manage Exams";
        button3.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(458, 216);
        button1.Name = "button1";
        button1.Size = new Size(346, 141);
        button1.TabIndex = 3;
        button1.Text = "Manage Students";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        button2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.Location = new Point(756, 20);
        button2.Name = "button2";
        button2.Size = new Size(107, 34);
        button2.TabIndex = 3;
        button2.Text = "Logout";
        button2.UseVisualStyleBackColor = true;
        // 
        // InstructorMainPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(panel1);
        Controls.Add(panel2);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "InstructorMainPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "InstructorMainPage";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button btnLogout;
    private Label label1;
    private Label lbWelcome;
    private Panel panel2;
    private Button button3;
    private Button button1;
    private Button button2;
}