namespace ExaminationSystem.Instructor;

partial class ChoiceQuestion
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
        lbBodyQuestion = new Label();
        txtBodyQuestion = new TextBox();
        btnAddQuestion = new Button();
        btnBack = new Button();
        groupBox1 = new GroupBox();
        dgvChoices = new DataGridView();
        btnAddChoice = new Button();
        textBox1 = new TextBox();
        nudMark = new NumericUpDown();
        lbMark = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChoices).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudMark).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(278, 18);
        label1.MaximumSize = new Size(900, 600);
        label1.Name = "label1";
        label1.Size = new Size(314, 41);
        label1.TabIndex = 2;
        label1.Text = "Add Choice Question";
        // 
        // lbBodyQuestion
        // 
        lbBodyQuestion.AutoSize = true;
        lbBodyQuestion.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbBodyQuestion.Location = new Point(36, 72);
        lbBodyQuestion.Name = "lbBodyQuestion";
        lbBodyQuestion.Size = new Size(127, 31);
        lbBodyQuestion.TabIndex = 5;
        lbBodyQuestion.Text = "Question :";
        lbBodyQuestion.Click += lbBodyQuestion_Click;
        // 
        // txtBodyQuestion
        // 
        txtBodyQuestion.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBodyQuestion.Location = new Point(36, 106);
        txtBodyQuestion.Multiline = true;
        txtBodyQuestion.Name = "txtBodyQuestion";
        txtBodyQuestion.PlaceholderText = "Add Question Here";
        txtBodyQuestion.Size = new Size(777, 103);
        txtBodyQuestion.TabIndex = 4;
        // 
        // btnAddQuestion
        // 
        btnAddQuestion.BackColor = SystemColors.HotTrack;
        btnAddQuestion.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAddQuestion.ForeColor = SystemColors.Control;
        btnAddQuestion.Location = new Point(299, 474);
        btnAddQuestion.Name = "btnAddQuestion";
        btnAddQuestion.Size = new Size(128, 47);
        btnAddQuestion.TabIndex = 20;
        btnAddQuestion.Text = "Save";
        btnAddQuestion.UseVisualStyleBackColor = false;
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(487, 474);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(128, 47);
        btnBack.TabIndex = 19;
        btnBack.Text = "Cancle";
        btnBack.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvChoices);
        groupBox1.Controls.Add(btnAddChoice);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Location = new Point(36, 227);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 220);
        groupBox1.TabIndex = 21;
        groupBox1.TabStop = false;
        groupBox1.Text = "Choose Answers";
        // 
        // dgvChoices
        // 
        dgvChoices.BackgroundColor = SystemColors.Control;
        dgvChoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChoices.Location = new Point(338, 26);
        dgvChoices.Name = "dgvChoices";
        dgvChoices.RowHeadersWidth = 51;
        dgvChoices.Size = new Size(336, 188);
        dgvChoices.TabIndex = 21;
        // 
        // btnAddChoice
        // 
        btnAddChoice.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAddChoice.Location = new Point(6, 167);
        btnAddChoice.Name = "btnAddChoice";
        btnAddChoice.Size = new Size(128, 47);
        btnAddChoice.TabIndex = 20;
        btnAddChoice.Text = "Add Choice";
        btnAddChoice.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(6, 26);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Add Choices Here ";
        textBox1.Size = new Size(326, 135);
        textBox1.TabIndex = 0;
        // 
        // nudMark
        // 
        nudMark.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        nudMark.Location = new Point(722, 291);
        nudMark.Name = "nudMark";
        nudMark.Size = new Size(150, 34);
        nudMark.TabIndex = 23;
        // 
        // lbMark
        // 
        lbMark.AutoSize = true;
        lbMark.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbMark.Location = new Point(722, 244);
        lbMark.Name = "lbMark";
        lbMark.Size = new Size(83, 31);
        lbMark.TabIndex = 22;
        lbMark.Text = "Mark :";
        // 
        // ChoiceQuestion
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(nudMark);
        Controls.Add(lbMark);
        Controls.Add(groupBox1);
        Controls.Add(btnAddQuestion);
        Controls.Add(btnBack);
        Controls.Add(lbBodyQuestion);
        Controls.Add(txtBodyQuestion);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "ChoiceQuestion";
        Text = "ChoiceQuestion";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChoices).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudMark).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lbBodyQuestion;
    private TextBox txtBodyQuestion;
    private Button btnAddQuestion;
    private Button btnBack;
    private GroupBox groupBox1;
    private DataGridView dgvChoices;
    private Button btnAddChoice;
    private TextBox textBox1;
    private NumericUpDown nudMark;
    private Label lbMark;
}