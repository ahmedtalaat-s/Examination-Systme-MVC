namespace ExaminationSystem.Admin;

partial class AddSubject
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
        txtSubject = new TextBox();
        btnBack = new Button();
        btnAddSubject = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(159, 20);
        label1.Name = "label1";
        label1.Size = new Size(271, 60);
        label1.TabIndex = 0;
        label1.Text = "Add Subject";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(205, 148);
        label2.Name = "label2";
        label2.Size = new Size(169, 31);
        label2.TabIndex = 1;
        label2.Text = "Subject Name";
        // 
        // txtSubject
        // 
        txtSubject.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSubject.Location = new Point(159, 182);
        txtSubject.Name = "txtSubject";
        txtSubject.Size = new Size(270, 38);
        txtSubject.TabIndex = 2;
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(12, 20);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(94, 29);
        btnBack.TabIndex = 8;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnAddSubject
        // 
        btnAddSubject.BackColor = SystemColors.HotTrack;
        btnAddSubject.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAddSubject.ForeColor = SystemColors.Control;
        btnAddSubject.Location = new Point(231, 269);
        btnAddSubject.Name = "btnAddSubject";
        btnAddSubject.Size = new Size(128, 47);
        btnAddSubject.TabIndex = 9;
        btnAddSubject.Text = "Save";
        btnAddSubject.UseVisualStyleBackColor = false;
        btnAddSubject.Click += button1_Click;
        // 
        // AddSubject
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(582, 353);
        Controls.Add(btnAddSubject);
        Controls.Add(btnBack);
        Controls.Add(txtSubject);
        Controls.Add(label2);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(600, 400);
        MinimumSize = new Size(600, 400);
        Name = "AddSubject";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AddSubject";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtSubject;
    private Button btnBack;
    private Button btnAddSubject;
}