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
        comboBox1 = new ComboBox();
        lbType = new Label();
        lbStatus = new Label();
        comboBox2 = new ComboBox();
        lbSubject = new Label();
        comboBox3 = new ComboBox();
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
        txtExamName.Size = new Size(199, 34);
        txtExamName.TabIndex = 2;
        // 
        // txtDuration
        // 
        txtDuration.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDuration.Location = new Point(128, 248);
        txtDuration.Name = "txtDuration";
        txtDuration.Size = new Size(199, 34);
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
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(128, 341);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(199, 28);
        comboBox1.TabIndex = 5;
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
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(491, 248);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(199, 28);
        comboBox2.TabIndex = 7;
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
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new Point(491, 159);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(199, 28);
        comboBox3.TabIndex = 9;
        comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
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
        dateTimePicker1.Size = new Size(199, 27);
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
        Controls.Add(comboBox3);
        Controls.Add(lbStatus);
        Controls.Add(comboBox2);
        Controls.Add(lbType);
        Controls.Add(comboBox1);
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

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtExamName;
    private TextBox txtDuration;
    private Label label3;
    private ComboBox comboBox1;
    private Label lbType;
    private Label lbStatus;
    private ComboBox comboBox2;
    private Label lbSubject;
    private ComboBox comboBox3;
    private Label label4;
    private Button btnSave;
    private Button btnCancle;
    private DateTimePicker dateTimePicker1;
}