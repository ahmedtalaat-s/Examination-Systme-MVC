namespace ExaminationSystem.Admin;

partial class EditStudent
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
        txtEmail = new TextBox();
        lbEmail = new Label();
        txtFullName = new TextBox();
        label2 = new Label();
        label1 = new Label();
        lbRole = new Label();
        cbRole = new ComboBox();
        txtPassword = new TextBox();
        label3 = new Label();
        btnEditStudent = new Button();
        button1 = new Button();
        dgvSubjects = new DataGridView();
        button2 = new Button();
        label4 = new Label();
        cbsubjects = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
        SuspendLayout();
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtEmail.Location = new Point(80, 277);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(244, 34);
        txtEmail.TabIndex = 11;
        // 
        // lbEmail
        // 
        lbEmail.AutoSize = true;
        lbEmail.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbEmail.Location = new Point(79, 243);
        lbEmail.Name = "lbEmail";
        lbEmail.Size = new Size(75, 31);
        lbEmail.TabIndex = 10;
        lbEmail.Text = "Email";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtFullName.Location = new Point(80, 179);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(244, 34);
        txtFullName.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(79, 145);
        label2.Name = "label2";
        label2.Size = new Size(126, 31);
        label2.TabIndex = 8;
        label2.Text = "Full Name";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(268, 30);
        label1.Name = "label1";
        label1.Size = new Size(295, 62);
        label1.TabIndex = 7;
        label1.Text = "Edit Student";
        // 
        // lbRole
        // 
        lbRole.AutoSize = true;
        lbRole.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbRole.Location = new Point(517, 145);
        lbRole.Name = "lbRole";
        lbRole.Size = new Size(70, 31);
        lbRole.TabIndex = 15;
        lbRole.Text = "Role ";
        // 
        // cbRole
        // 
        cbRole.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbRole.FormattingEnabled = true;
        cbRole.Location = new Point(517, 179);
        cbRole.Name = "cbRole";
        cbRole.Size = new Size(244, 36);
        cbRole.TabIndex = 14;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(79, 376);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(244, 34);
        txtPassword.TabIndex = 13;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(79, 342);
        label3.Name = "label3";
        label3.Size = new Size(119, 31);
        label3.TabIndex = 12;
        label3.Text = "Password";
        // 
        // btnEditStudent
        // 
        btnEditStudent.BackColor = SystemColors.HotTrack;
        btnEditStudent.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnEditStudent.ForeColor = SystemColors.Control;
        btnEditStudent.Location = new Point(157, 478);
        btnEditStudent.Name = "btnEditStudent";
        btnEditStudent.Size = new Size(245, 50);
        btnEditStudent.TabIndex = 16;
        btnEditStudent.Text = "Edit";
        btnEditStudent.UseVisualStyleBackColor = false;
        btnEditStudent.Click += btnEditStudent_Click;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(456, 478);
        button1.Name = "button1";
        button1.Size = new Size(242, 50);
        button1.TabIndex = 18;
        button1.Text = "Cancle";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // dgvSubjects
        // 
        dgvSubjects.BackgroundColor = SystemColors.Control;
        dgvSubjects.BorderStyle = BorderStyle.None;
        dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSubjects.GridColor = SystemColors.Control;
        dgvSubjects.Location = new Point(517, 320);
        dgvSubjects.Name = "dgvSubjects";
        dgvSubjects.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgvSubjects.RowHeadersWidth = 51;
        dgvSubjects.Size = new Size(317, 132);
        dgvSubjects.TabIndex = 22;
        dgvSubjects.CellContentClick += dgvSubjects_CellContentClick;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.Location = new Point(788, 270);
        button2.Name = "button2";
        button2.Size = new Size(46, 34);
        button2.TabIndex = 21;
        button2.Text = "+";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(517, 234);
        label4.Name = "label4";
        label4.Size = new Size(108, 31);
        label4.TabIndex = 20;
        label4.Text = "Subjects";
        // 
        // cbsubjects
        // 
        cbsubjects.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbsubjects.FormattingEnabled = true;
        cbsubjects.Location = new Point(517, 268);
        cbsubjects.Name = "cbsubjects";
        cbsubjects.Size = new Size(244, 36);
        cbsubjects.TabIndex = 19;
        // 
        // EditStudent
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(dgvSubjects);
        Controls.Add(button2);
        Controls.Add(label4);
        Controls.Add(cbsubjects);
        Controls.Add(button1);
        Controls.Add(btnEditStudent);
        Controls.Add(lbRole);
        Controls.Add(cbRole);
        Controls.Add(txtPassword);
        Controls.Add(label3);
        Controls.Add(txtEmail);
        Controls.Add(lbEmail);
        Controls.Add(txtFullName);
        Controls.Add(label2);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "EditStudent";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EditStudent";
        Load += EditStudent_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtEmail;
    private Label lbEmail;
    private TextBox txtFullName;
    private Label label2;
    private Label label1;
    private Label lbRole;
    private ComboBox cbRole;
    private TextBox txtPassword;
    private Label label3;
    private Button btnEditStudent;
    private Button button1;
    private DataGridView dgvSubjects;
    private Button button2;
    private Label label4;
    private ComboBox cbsubjects;
}