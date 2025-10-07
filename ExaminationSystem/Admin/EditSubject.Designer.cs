namespace ExaminationSystem.Admin;

partial class EditSubject
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
        textBox1 = new TextBox();
        label2 = new Label();
        lbEditSubject = new Label();
        btnBack = new Button();
        btnEdit = new Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(164, 188);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(270, 38);
        textBox1.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(210, 154);
        label2.Name = "label2";
        label2.Size = new Size(169, 31);
        label2.TabIndex = 4;
        label2.Text = "Subject Name";
        // 
        // lbEditSubject
        // 
        lbEditSubject.AutoSize = true;
        lbEditSubject.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbEditSubject.Location = new Point(164, 26);
        lbEditSubject.Name = "lbEditSubject";
        lbEditSubject.Size = new Size(266, 60);
        lbEditSubject.TabIndex = 3;
        lbEditSubject.Text = "Edit Subject";
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(325, 264);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(121, 47);
        btnBack.TabIndex = 9;
        btnBack.Text = "Cancle";
        btnBack.UseVisualStyleBackColor = true;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = SystemColors.HotTrack;
        btnEdit.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnEdit.ForeColor = SystemColors.Control;
        btnEdit.Location = new Point(141, 264);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(128, 47);
        btnEdit.TabIndex = 10;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = false;
        // 
        // EditSubject
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(582, 353);
        Controls.Add(btnEdit);
        Controls.Add(btnBack);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(lbEditSubject);
        MaximizeBox = false;
        MaximumSize = new Size(600, 400);
        MinimumSize = new Size(600, 400);
        Name = "EditSubject";
        Text = "EditSubject";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Label label2;
    private Label lbEditSubject;
    private Button btnBack;
    private Button btnEdit;
}