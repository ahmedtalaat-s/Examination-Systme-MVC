namespace ExaminationSystem.Instructor;

partial class AddExam
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
        txtExamName = new TextBox();
        txtDuration = new TextBox();
        label3 = new Label();
        cbType = new ComboBox();
        lbType = new Label();
        lbStatus = new Label();
        cbStatus = new ComboBox();
        lbSubject = new Label();
        cbsubjects = new ComboBox();
        label4 = new Label();
        btnSave = new Button();
        btnCancle = new Button();
        dateTimePicker1 = new DateTimePicker();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(300, 25);
        label1.Name = "label1";
        label1.Size = new Size(244, 62);
        label1.TabIndex = 0;
        label1.Text = "Add Exam";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(128, 125);
        label2.Name = "label2";
        label2.Size = new Size(145, 31);
        label2.TabIndex = 1;
        label2.Text = "Exam Name";
        // 
        // txtExamName
        // 
        txtExamName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtExamName.Location = new Point(128, 159);
        txtExamName.Name = "txtExamName";
        txtExamName.Size = new Size(258, 34);
        txtExamName.TabIndex = 2;
        txtExamName.TextChanged += txtExamName_TextChanged;
        // 
        // txtDuration
        // 
        txtDuration.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDuration.Location = new Point(128, 248);
        txtDuration.Name = "txtDuration";
        txtDuration.Size = new Size(258, 34);
        txtDuration.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(128, 214);
        label3.Name = "label3";
        label3.Size = new Size(111, 31);
        label3.TabIndex = 3;
        label3.Text = "Duration";
        // 
        // cbType
        // 
        cbType.FormattingEnabled = true;
        cbType.Location = new Point(128, 341);
        cbType.Name = "cbType";
        cbType.Size = new Size(258, 28);
        cbType.TabIndex = 5;
        // 
        // lbType
        // 
        lbType.AutoSize = true;
        lbType.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbType.Location = new Point(128, 307);
        lbType.Name = "lbType";
        lbType.Size = new Size(67, 31);
        lbType.TabIndex = 6;
        lbType.Text = "Type";
        lbType.Click += label4_Click;
        // 
        // lbStatus
        // 
        lbStatus.AutoSize = true;
        lbStatus.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbStatus.Location = new Point(491, 214);
        lbStatus.Name = "lbStatus";
        lbStatus.Size = new Size(83, 31);
        lbStatus.TabIndex = 8;
        lbStatus.Text = "Status";
        // 
        // cbStatus
        // 
        cbStatus.FormattingEnabled = true;
        cbStatus.Location = new Point(491, 248);
        cbStatus.Name = "cbStatus";
        cbStatus.Size = new Size(258, 28);
        cbStatus.TabIndex = 7;
        // 
        // lbSubject
        // 
        lbSubject.AutoSize = true;
        lbSubject.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbSubject.Location = new Point(491, 125);
        lbSubject.Name = "lbSubject";
        lbSubject.Size = new Size(97, 31);
        lbSubject.TabIndex = 10;
        lbSubject.Text = "Subject";
        // 
        // cbsubjects
        // 
        cbsubjects.FormattingEnabled = true;
        cbsubjects.Location = new Point(491, 159);
        cbsubjects.Name = "cbsubjects";
        cbsubjects.Size = new Size(258, 28);
        cbsubjects.TabIndex = 9;
        cbsubjects.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(491, 307);
        label4.Name = "label4";
        label4.Size = new Size(128, 31);
        label4.TabIndex = 11;
        label4.Text = "Start Time";
        // 
        // btnSave
        // 
        btnSave.BackColor = SystemColors.HotTrack;
        btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(201, 443);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(185, 59);
        btnSave.TabIndex = 13;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancle
        // 
        btnCancle.BackColor = SystemColors.Control;
        btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancle.ForeColor = SystemColors.InfoText;
        btnCancle.Location = new Point(434, 443);
        btnCancle.Name = "btnCancle";
        btnCancle.Size = new Size(185, 59);
        btnCancle.TabIndex = 14;
        btnCancle.Text = "Cancle";
        btnCancle.UseVisualStyleBackColor = false;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new Point(491, 342);
        dateTimePicker1.MinDate = new DateTime(2025, 10, 7, 0, 0, 0, 0);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(258, 27);
        dateTimePicker1.TabIndex = 15;
        dateTimePicker1.Value = new DateTime(2025, 10, 7, 19, 21, 4, 0);
        // 
        // AddExam
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(dateTimePicker1);
        Controls.Add(btnCancle);
        Controls.Add(btnSave);
        Controls.Add(label4);
        Controls.Add(lbSubject);
        Controls.Add(cbsubjects);
        Controls.Add(lbStatus);
        Controls.Add(cbStatus);
        Controls.Add(lbType);
        Controls.Add(cbType);
        Controls.Add(txtDuration);
        Controls.Add(label3);
        Controls.Add(txtExamName);
        Controls.Add(label2);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "AddExam";
        Text = "AddExam";
        Load += AddExam_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private void txtExamName_TextChanged(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtExamName;
    private TextBox txtDuration;
    private Label label3;
    private ComboBox cbType;
    private Label lbType;
    private Label lbStatus;
    private ComboBox cbStatus;
    private Label lbSubject;
    private ComboBox cbsubjects;
    private Label label4;
    private Button btnSave;
    private Button btnCancle;
    private DateTimePicker dateTimePicker1;
}