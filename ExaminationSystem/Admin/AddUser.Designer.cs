namespace ExaminationSystem.Admin;

partial class AddUser
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
        label1 = new Label();
        label2 = new Label();
        txtFullName = new TextBox();
        txtPassword = new TextBox();
        label3 = new Label();
        txtEmail = new TextBox();
        lbEmail = new Label();
        btnBack = new Button();
        cbRole = new ComboBox();
        lbRole = new Label();
        btnAddStudent = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(272, 29);
        label1.Name = "label1";
        label1.Size = new Size(301, 62);
        label1.TabIndex = 0;
        label1.Text = "Add Student";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(113, 166);
        label2.Name = "label2";
        label2.Size = new Size(126, 31);
        label2.TabIndex = 1;
        label2.Text = "Full Name";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtFullName.Location = new Point(114, 200);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(244, 34);
        txtFullName.TabIndex = 2;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(113, 323);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(244, 34);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(113, 289);
        label3.Name = "label3";
        label3.Size = new Size(119, 31);
        label3.TabIndex = 3;
        label3.Text = "Password";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtEmail.Location = new Point(525, 200);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(244, 34);
        txtEmail.TabIndex = 6;
        // 
        // lbEmail
        // 
        lbEmail.AutoSize = true;
        lbEmail.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbEmail.Location = new Point(524, 166);
        lbEmail.Name = "lbEmail";
        lbEmail.Size = new Size(75, 31);
        lbEmail.TabIndex = 5;
        lbEmail.Text = "Email";
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(484, 425);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(242, 50);
        btnBack.TabIndex = 9;
        btnBack.Text = "Cancle";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // cbRole
        // 
        cbRole.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbRole.FormattingEnabled = true;
        cbRole.Location = new Point(526, 323);
        cbRole.Name = "cbRole";
        cbRole.Size = new Size(244, 36);
        cbRole.TabIndex = 10;
        // 
        // lbRole
        // 
        lbRole.AutoSize = true;
        lbRole.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbRole.Location = new Point(526, 289);
        lbRole.Name = "lbRole";
        lbRole.Size = new Size(70, 31);
        lbRole.TabIndex = 11;
        lbRole.Text = "Role ";
        // 
        // btnAddStudent
        // 
        btnAddStudent.BackColor = SystemColors.HotTrack;
        btnAddStudent.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAddStudent.ForeColor = SystemColors.Control;
        btnAddStudent.Location = new Point(167, 425);
        btnAddStudent.Name = "btnAddStudent";
        btnAddStudent.Size = new Size(245, 50);
        btnAddStudent.TabIndex = 12;
        btnAddStudent.Text = "Add";
        btnAddStudent.UseVisualStyleBackColor = false;
        btnAddStudent.Click += btnAddStudent_Click;
        // 
        // AddUser
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(btnAddStudent);
        Controls.Add(lbRole);
        Controls.Add(cbRole);
        Controls.Add(btnBack);
        Controls.Add(txtEmail);
        Controls.Add(lbEmail);
        Controls.Add(txtPassword);
        Controls.Add(label3);
        Controls.Add(txtFullName);
        Controls.Add(label2);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "AddUser";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddUser";
        Load += AddUser_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtFullName;
    private TextBox txtPassword;
    private Label label3;
    private TextBox txtEmail;
    private Label lbEmail;
    private Button btnBack;
    private ComboBox cbRole;
    private Label lbRole;
    private Button btnAddStudent;
}