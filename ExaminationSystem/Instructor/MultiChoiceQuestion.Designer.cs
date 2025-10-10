namespace ExaminationSystem.Instructor;

partial class MultiChoiceQuestion
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
        txtQuestionBody = new TextBox();
        btnAddChoice = new Button();
        txtChoice = new TextBox();
        groupBox1 = new GroupBox();
        dgvChoices = new DataGridView();
        numMark = new NumericUpDown();
        lbMark = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChoices).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(238, 32);
        label1.MaximumSize = new Size(900, 600);
        label1.Name = "label1";
        label1.Size = new Size(399, 41);
        label1.TabIndex = 3;
        label1.Text = "Add Multi Choice Question";
        // 
        // lbBodyQuestion
        // 
        lbBodyQuestion.AutoSize = true;
        lbBodyQuestion.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbBodyQuestion.Location = new Point(41, 80);
        lbBodyQuestion.Name = "lbBodyQuestion";
        lbBodyQuestion.Size = new Size(127, 31);
        lbBodyQuestion.TabIndex = 7;
        lbBodyQuestion.Text = "Question :";
        // 
        // txtQuestionBody
        // 
        txtQuestionBody.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtQuestionBody.Location = new Point(41, 114);
        txtQuestionBody.Multiline = true;
        txtQuestionBody.Name = "txtQuestionBody";
        txtQuestionBody.PlaceholderText = "Add Question Here";
        txtQuestionBody.Size = new Size(829, 97);
        txtQuestionBody.TabIndex = 6;
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
        btnAddChoice.Click += btnAddChoice_Click;
        // 
        // txtChoice
        // 
        txtChoice.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtChoice.Location = new Point(6, 26);
        txtChoice.Multiline = true;
        txtChoice.Name = "txtChoice";
        txtChoice.PlaceholderText = "Add Choices Here ";
        txtChoice.Size = new Size(326, 135);
        txtChoice.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvChoices);
        groupBox1.Controls.Add(btnAddChoice);
        groupBox1.Controls.Add(txtChoice);
        groupBox1.Location = new Point(41, 217);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 220);
        groupBox1.TabIndex = 8;
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
        // numMark
        // 
        numMark.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        numMark.Location = new Point(727, 286);
        numMark.Name = "numMark";
        numMark.Size = new Size(150, 34);
        numMark.TabIndex = 18;
        // 
        // lbMark
        // 
        lbMark.AutoSize = true;
        lbMark.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbMark.Location = new Point(727, 239);
        lbMark.Name = "lbMark";
        lbMark.Size = new Size(83, 31);
        lbMark.TabIndex = 17;
        lbMark.Text = "Mark :";
        // 
        // btnSave
        // 
        btnSave.BackColor = SystemColors.HotTrack;
        btnSave.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = SystemColors.Control;
        btnSave.Location = new Point(296, 466);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(128, 47);
        btnSave.TabIndex = 22;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancel.Location = new Point(484, 466);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(128, 47);
        btnCancel.TabIndex = 21;
        btnCancel.Text = "Cancle";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // MultiChoiceQuestion
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(numMark);
        Controls.Add(lbMark);
        Controls.Add(groupBox1);
        Controls.Add(lbBodyQuestion);
        Controls.Add(txtQuestionBody);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "MultiChoiceQuestion";
        Text = "MultiChoiceQuestion";
        Load += MultiChoiceQuestion_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChoices).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lbBodyQuestion;
    private TextBox txtQuestionBody;
    private Button btnAddChoice;
    private TextBox txtChoice;
    private GroupBox groupBox1;
    private DataGridView dgvChoices;
    private NumericUpDown numMark;
    private Label lbMark;
    private Button btnSave;
    private Button btnCancel;
}