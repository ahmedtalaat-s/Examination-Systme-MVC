namespace ExaminationSystem.Instructor;

partial class TrueOrFalseQuestion
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
        txtQuestionBody = new TextBox();
        lbBodyQuestion = new Label();
        grpAnswers = new GroupBox();
        rbFalse = new RadioButton();
        rbTrue = new RadioButton();
        btnSave = new Button();
        btnBack = new Button();
        lbMark = new Label();
        numMarks = new NumericUpDown();
        grpAnswers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numMarks).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(229, 22);
        label1.MaximumSize = new Size(900, 600);
        label1.Name = "label1";
        label1.Size = new Size(402, 41);
        label1.TabIndex = 1;
        label1.Text = "Add True Or False Question";
        // 
        // txtQuestionBody
        // 
        txtQuestionBody.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtQuestionBody.Location = new Point(134, 141);
        txtQuestionBody.Multiline = true;
        txtQuestionBody.Name = "txtQuestionBody";
        txtQuestionBody.Size = new Size(603, 102);
        txtQuestionBody.TabIndex = 2;
        // 
        // lbBodyQuestion
        // 
        lbBodyQuestion.AutoSize = true;
        lbBodyQuestion.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbBodyQuestion.Location = new Point(134, 107);
        lbBodyQuestion.Name = "lbBodyQuestion";
        lbBodyQuestion.Size = new Size(127, 31);
        lbBodyQuestion.TabIndex = 3;
        lbBodyQuestion.Text = "Question :";
        // 
        // grpAnswers
        // 
        grpAnswers.Controls.Add(rbFalse);
        grpAnswers.Controls.Add(rbTrue);
        grpAnswers.Location = new Point(134, 261);
        grpAnswers.Name = "grpAnswers";
        grpAnswers.Size = new Size(285, 94);
        grpAnswers.TabIndex = 4;
        grpAnswers.TabStop = false;
        grpAnswers.Text = "Is Correct";
        // 
        // rbFalse
        // 
        rbFalse.AutoSize = true;
        rbFalse.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbFalse.Location = new Point(194, 38);
        rbFalse.Name = "rbFalse";
        rbFalse.Size = new Size(76, 32);
        rbFalse.TabIndex = 1;
        rbFalse.TabStop = true;
        rbFalse.Text = "False";
        rbFalse.UseVisualStyleBackColor = true;
        // 
        // rbTrue
        // 
        rbTrue.AutoSize = true;
        rbTrue.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        rbTrue.Location = new Point(15, 38);
        rbTrue.Name = "rbTrue";
        rbTrue.Size = new Size(71, 32);
        rbTrue.TabIndex = 0;
        rbTrue.TabStop = true;
        rbTrue.Text = "True";
        rbTrue.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.BackColor = SystemColors.HotTrack;
        btnSave.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = SystemColors.Control;
        btnSave.Location = new Point(287, 413);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(128, 47);
        btnSave.TabIndex = 11;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(475, 413);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(128, 47);
        btnBack.TabIndex = 10;
        btnBack.Text = "Cancle";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click_1;
        // 
        // lbMark
        // 
        lbMark.AutoSize = true;
        lbMark.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbMark.Location = new Point(487, 300);
        lbMark.Name = "lbMark";
        lbMark.Size = new Size(83, 31);
        lbMark.TabIndex = 12;
        lbMark.Text = "Mark :";
        // 
        // numMarks
        // 
        numMarks.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        numMarks.Location = new Point(587, 297);
        numMarks.Name = "numMarks";
        numMarks.Size = new Size(150, 34);
        numMarks.TabIndex = 14;
        // 
        // TrueOrFalseQuestion
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(numMarks);
        Controls.Add(lbMark);
        Controls.Add(btnSave);
        Controls.Add(btnBack);
        Controls.Add(grpAnswers);
        Controls.Add(lbBodyQuestion);
        Controls.Add(txtQuestionBody);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "TrueOrFalseQuestion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "TrueOrFalseQuestion";
        grpAnswers.ResumeLayout(false);
        grpAnswers.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numMarks).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtQuestionBody;
    private Label lbBodyQuestion;
    private GroupBox grpAnswers;
    private RadioButton rbFalse;
    private RadioButton rbTrue;
    private Button btnSave;
    private Button btnBack;
    private Label lbMark;
    private NumericUpDown numMarks;
}