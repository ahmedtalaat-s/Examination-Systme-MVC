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
        btnBack = new Button();
        SuspendLayout();
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtEmail.Location = new Point(551, 216);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(244, 34);
        txtEmail.TabIndex = 11;
        // 
        // lbEmail
        // 
        lbEmail.AutoSize = true;
        lbEmail.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbEmail.Location = new Point(550, 182);
        lbEmail.Name = "lbEmail";
        lbEmail.Size = new Size(75, 31);
        lbEmail.TabIndex = 10;
        lbEmail.Text = "Email";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtFullName.Location = new Point(80, 216);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(244, 34);
        txtFullName.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(79, 182);
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
        lbRole.Location = new Point(553, 314);
        lbRole.Name = "lbRole";
        lbRole.Size = new Size(70, 31);
        lbRole.TabIndex = 15;
        lbRole.Text = "Role ";
        // 
        // cbRole
        // 
        cbRole.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbRole.FormattingEnabled = true;
        cbRole.Location = new Point(553, 348);
        cbRole.Name = "cbRole";
        cbRole.Size = new Size(244, 36);
        cbRole.TabIndex = 14;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(80, 348);
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
        label3.Location = new Point(80, 314);
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
        btnEditStudent.Location = new Point(313, 445);
        btnEditStudent.Name = "btnEditStudent";
        btnEditStudent.Size = new Size(245, 50);
        btnEditStudent.TabIndex = 16;
        btnEditStudent.Text = "Edit";
        btnEditStudent.UseVisualStyleBackColor = false;
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(39, 30);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(94, 29);
        btnBack.TabIndex = 17;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        // 
        // EditStudent
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(btnBack);
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
    private Button btnBack;
}