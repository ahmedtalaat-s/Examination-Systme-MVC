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
        lbWelcome = new Label();
        label1 = new Label();
        btnLogout = new Button();
        panel2 = new Panel();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        label2 = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
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
        // 
        // panel2
        // 
        panel2.Controls.Add(label2);
        panel2.Controls.Add(button3);
        panel2.Controls.Add(button2);
        panel2.Controls.Add(button1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 70);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(32);
        panel2.Size = new Size(882, 483);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // button1
        // 
        button1.Location = new Point(592, 184);
        button1.Name = "button1";
        button1.Size = new Size(254, 149);
        button1.TabIndex = 0;
        button1.Text = "Final Exams";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.HotTrack;
        button2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.ForeColor = SystemColors.ControlLightLight;
        button2.Location = new Point(318, 184);
        button2.Name = "button2";
        button2.Size = new Size(254, 149);
        button2.TabIndex = 1;
        button2.Text = "Reports";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.Location = new Point(44, 184);
        button3.Name = "button3";
        button3.Size = new Size(254, 149);
        button3.TabIndex = 2;
        button3.Text = "Practice Exams";
        button3.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = SystemColors.HotTrack;
        label2.Font = new Font("Segoe UI Symbol", 9F);
        label2.ForeColor = Color.Snow;
        label2.Location = new Point(342, 285);
        label2.Name = "label2";
        label2.Size = new Size(208, 20);
        label2.TabIndex = 3;
        label2.Text = "View and export exam reports";
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
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "StudentMainPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Page";
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
    private Button button3;
    private Button button2;
    private Button button1;
    private Label label2;
}