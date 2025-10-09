namespace ExaminationSystem.Instructor;

partial class ChoseQuestionType
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
        groupBox1 = new GroupBox();
        rbMultiChoice = new RadioButton();
        rbChoice = new RadioButton();
        rbTrueOrFalse = new RadioButton();
        btnCancle = new Button();
        btnNext = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(182, 29);
        label1.MaximumSize = new Size(900, 600);
        label1.Name = "label1";
        label1.Size = new Size(217, 38);
        label1.TabIndex = 4;
        label1.Text = "Questions Type";
        label1.Click += label1_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rbMultiChoice);
        groupBox1.Controls.Add(rbChoice);
        groupBox1.Controls.Add(rbTrueOrFalse);
        groupBox1.Location = new Point(12, 93);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(558, 80);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Type";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // rbMultiChoice
        // 
        rbMultiChoice.AutoSize = true;
        rbMultiChoice.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbMultiChoice.Location = new Point(405, 36);
        rbMultiChoice.Name = "rbMultiChoice";
        rbMultiChoice.Size = new Size(127, 27);
        rbMultiChoice.TabIndex = 2;
        rbMultiChoice.Text = "Multi Choice";
        rbMultiChoice.UseVisualStyleBackColor = true;
        rbMultiChoice.CheckedChanged += rbMultiChoice_CheckedChanged;
        // 
        // rbChoice
        // 
        rbChoice.AutoSize = true;
        rbChoice.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbChoice.Location = new Point(214, 36);
        rbChoice.Name = "rbChoice";
        rbChoice.Size = new Size(83, 27);
        rbChoice.TabIndex = 1;
        rbChoice.Text = "Choice";
        rbChoice.UseVisualStyleBackColor = true;
        rbChoice.CheckedChanged += rbChoice_CheckedChanged;
        // 
        // rbTrueOrFalse
        // 
        rbTrueOrFalse.AutoSize = true;
        rbTrueOrFalse.Checked = true;
        rbTrueOrFalse.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbTrueOrFalse.Location = new Point(16, 36);
        rbTrueOrFalse.Name = "rbTrueOrFalse";
        rbTrueOrFalse.Size = new Size(131, 27);
        rbTrueOrFalse.TabIndex = 0;
        rbTrueOrFalse.TabStop = true;
        rbTrueOrFalse.Text = "True Or False";
        rbTrueOrFalse.UseVisualStyleBackColor = true;
        rbTrueOrFalse.CheckedChanged += rbTrueOrFalse_CheckedChanged;
        // 
        // btnCancle
        // 
        btnCancle.BackColor = SystemColors.Control;
        btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancle.ForeColor = SystemColors.InfoText;
        btnCancle.Location = new Point(315, 241);
        btnCancle.Name = "btnCancle";
        btnCancle.Size = new Size(185, 59);
        btnCancle.TabIndex = 16;
        btnCancle.Text = "Cancle";
        btnCancle.UseVisualStyleBackColor = false;
        btnCancle.Click += btnCancle_Click;
        // 
        // btnNext
        // 
        btnNext.BackColor = SystemColors.HotTrack;
        btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnNext.ForeColor = Color.White;
        btnNext.Location = new Point(82, 241);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(185, 59);
        btnNext.TabIndex = 15;
        btnNext.Text = "Next";
        btnNext.UseVisualStyleBackColor = false;
        btnNext.Click += btnNext_Click;
        // 
        // ChoseQuestionType
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(582, 353);
        Controls.Add(btnCancle);
        Controls.Add(btnNext);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(600, 400);
        MinimumSize = new Size(600, 400);
        Name = "ChoseQuestionType";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ChoseQuestionType";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private GroupBox groupBox1;
    private RadioButton rbTrueOrFalse;
    private RadioButton rbMultiChoice;
    private RadioButton rbChoice;
    private Button btnCancle;
    private Button btnNext;
}