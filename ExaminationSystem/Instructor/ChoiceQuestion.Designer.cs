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
        txtQuestionBody = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        groupBox1 = new GroupBox();
        dgvChoices = new DataGridView();
        btnAddChoice = new Button();
        txtChoice = new TextBox();
        numMark = new NumericUpDown();
        lbMark = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChoices).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
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
        // txtQuestionBody
        // 
        txtQuestionBody.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtQuestionBody.Location = new Point(36, 106);
        txtQuestionBody.Multiline = true;
        txtQuestionBody.Name = "txtQuestionBody";
        txtQuestionBody.PlaceholderText = "Add Question Here";
        txtQuestionBody.Size = new Size(777, 103);
        txtQuestionBody.TabIndex = 4;
        // 
        // btnSave
        // 
        btnSave.BackColor = SystemColors.HotTrack;
        btnSave.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = SystemColors.Control;
        btnSave.Location = new Point(299, 474);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(128, 47);
        btnSave.TabIndex = 20;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancel.Location = new Point(487, 474);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(128, 47);
        btnCancel.TabIndex = 19;
        btnCancel.Text = "Cancle";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvChoices);
        groupBox1.Controls.Add(btnAddChoice);
        groupBox1.Controls.Add(txtChoice);
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
        dgvChoices.CellContentClick += dgvChoices_CellContentClick;
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
        // numMark
        // 
        numMark.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        numMark.Location = new Point(722, 291);
        numMark.Name = "numMark";
        numMark.Size = new Size(150, 34);
        numMark.TabIndex = 23;
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
        Controls.Add(numMark);
        Controls.Add(lbMark);
        Controls.Add(groupBox1);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(lbBodyQuestion);
        Controls.Add(txtQuestionBody);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "ChoiceQuestion";
        Text = "ChoiceQuestion";
        Load += ChoiceQuestion_Load;
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
    private Button btnSave;
    private Button btnCancel;
    private GroupBox groupBox1;
    private DataGridView dgvChoices;
    private Button btnAddChoice;
    private TextBox txtChoice;
    private NumericUpDown numMark;
    private Label lbMark;
}