namespace ExaminationSystem.Admin;

partial class LoginForm
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
        pictureBox1 = new PictureBox();
        label1 = new Label();
        lbEmail = new Label();
        lbPassword = new Label();
        txtEmail = new TextBox();
        txtPassword = new TextBox();
        checkBox1 = new CheckBox();
        linkLabel1 = new LinkLabel();
        btnLogin = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.LoginIcon;
        pictureBox1.Location = new Point(284, 47);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(225, 226);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(188, 276);
        label1.Name = "label1";
        label1.Size = new Size(447, 54);
        label1.TabIndex = 1;
        label1.Text = "Login To Your Account";
        // 
        // lbEmail
        // 
        lbEmail.AutoSize = true;
        lbEmail.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbEmail.Location = new Point(261, 343);
        lbEmail.Name = "lbEmail";
        lbEmail.Size = new Size(75, 31);
        lbEmail.TabIndex = 2;
        lbEmail.Text = "Email";
        // 
        // lbPassword
        // 
        lbPassword.AutoSize = true;
        lbPassword.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbPassword.Location = new Point(261, 429);
        lbPassword.Name = "lbPassword";
        lbPassword.Size = new Size(119, 31);
        lbPassword.TabIndex = 3;
        lbPassword.Text = "Password";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(261, 377);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(305, 27);
        txtEmail.TabIndex = 4;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(261, 463);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(305, 27);
        txtPassword.TabIndex = 5;
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.TextChanged += txtPassword_TextChanged;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(261, 496);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(129, 24);
        checkBox1.TabIndex = 6;
        checkBox1.Text = "Remember me";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.LinkColor = Color.DimGray;
        linkLabel1.Location = new Point(446, 500);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(120, 20);
        linkLabel1.TabIndex = 7;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "ForgetPassword?";
        // 
        // btnLogin
        // 
        btnLogin.BackColor = SystemColors.ActiveCaptionText;
        btnLogin.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = SystemColors.ButtonHighlight;
        btnLogin.Location = new Point(261, 557);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(305, 61);
        btnLogin.TabIndex = 8;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Window;
        ClientSize = new Size(800, 688);
        Controls.Add(btnLogin);
        Controls.Add(linkLabel1);
        Controls.Add(checkBox1);
        Controls.Add(txtPassword);
        Controls.Add(txtEmail);
        Controls.Add(lbPassword);
        Controls.Add(lbEmail);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MaximumSize = new Size(818, 735);
        MinimumSize = new Size(818, 735);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label lbEmail;
    private Label lbPassword;
    private TextBox txtEmail;
    private TextBox txtPassword;
    private CheckBox checkBox1;
    private LinkLabel linkLabel1;
    private Button btnLogin;
}