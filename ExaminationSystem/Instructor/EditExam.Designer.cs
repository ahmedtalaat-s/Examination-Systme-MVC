namespace ExaminationSystem.Instructor;

partial class EditExam
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
        lbSubject = new Label();
        comboBox3 = new ComboBox();
        txtExamName = new TextBox();
        label2 = new Label();
        lbStatus = new Label();
        comboBox2 = new ComboBox();
        txtDuration = new TextBox();
        label3 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label4 = new Label();
        lbType = new Label();
        comboBox1 = new ComboBox();
        btnCancle = new Button();
        btnSave = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(294, 36);
        label1.Name = "label1";
        label1.Size = new Size(238, 62);
        label1.TabIndex = 1;
        label1.Text = "Edit Exam";
        // 
        // lbSubject
        // 
        lbSubject.AutoSize = true;
        lbSubject.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbSubject.Location = new Point(487, 124);
        lbSubject.Name = "lbSubject";
        lbSubject.Size = new Size(97, 31);
        lbSubject.TabIndex = 14;
        lbSubject.Text = "Subject";
        // 
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new Point(487, 158);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(199, 28);
        comboBox3.TabIndex = 13;
        // 
        // txtExamName
        // 
        txtExamName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtExamName.Location = new Point(124, 158);
        txtExamName.Name = "txtExamName";
        txtExamName.Size = new Size(199, 34);
        txtExamName.TabIndex = 12;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(124, 124);
        label2.Name = "label2";
        label2.Size = new Size(145, 31);
        label2.TabIndex = 11;
        label2.Text = "Exam Name";
        // 
        // lbStatus
        // 
        lbStatus.AutoSize = true;
        lbStatus.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbStatus.Location = new Point(487, 223);
        lbStatus.Name = "lbStatus";
        lbStatus.Size = new Size(83, 31);
        lbStatus.TabIndex = 18;
        lbStatus.Text = "Status";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(487, 257);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(199, 28);
        comboBox2.TabIndex = 17;
        // 
        // txtDuration
        // 
        txtDuration.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDuration.Location = new Point(124, 257);
        txtDuration.Name = "txtDuration";
        txtDuration.Size = new Size(199, 34);
        txtDuration.TabIndex = 16;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(124, 223);
        label3.Name = "label3";
        label3.Size = new Size(111, 31);
        label3.TabIndex = 15;
        label3.Text = "Duration";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new Font("Segoe UI Symbol", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new Point(487, 364);
        dateTimePicker1.MinDate = new DateTime(2025, 10, 7, 0, 0, 0, 0);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(199, 27);
        dateTimePicker1.TabIndex = 22;
        dateTimePicker1.Value = new DateTime(2025, 10, 7, 19, 21, 4, 0);
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(487, 329);
        label4.Name = "label4";
        label4.Size = new Size(128, 31);
        label4.TabIndex = 21;
        label4.Text = "Start Time";
        // 
        // lbType
        // 
        lbType.AutoSize = true;
        lbType.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbType.Location = new Point(124, 329);
        lbType.Name = "lbType";
        lbType.Size = new Size(67, 31);
        lbType.TabIndex = 20;
        lbType.Text = "Type";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(124, 363);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(199, 28);
        comboBox1.TabIndex = 19;
        // 
        // btnCancle
        // 
        btnCancle.BackColor = SystemColors.Control;
        btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCancle.ForeColor = SystemColors.InfoText;
        btnCancle.Location = new Point(430, 444);
        btnCancle.Name = "btnCancle";
        btnCancle.Size = new Size(185, 59);
        btnCancle.TabIndex = 24;
        btnCancle.Text = "Cancle";
        btnCancle.UseVisualStyleBackColor = false;
        //btnCancle.Click += btnCancle_Click;
        // 
        // btnSave
        // 
        btnSave.BackColor = SystemColors.HotTrack;
        btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(197, 444);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(185, 59);
        btnSave.TabIndex = 23;
        btnSave.Text = "Edit";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // EditExam
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(btnCancle);
        Controls.Add(btnSave);
        Controls.Add(dateTimePicker1);
        Controls.Add(label4);
        Controls.Add(lbType);
        Controls.Add(comboBox1);
        Controls.Add(lbStatus);
        Controls.Add(comboBox2);
        Controls.Add(txtDuration);
        Controls.Add(label3);
        Controls.Add(lbSubject);
        Controls.Add(comboBox3);
        Controls.Add(txtExamName);
        Controls.Add(label2);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "EditExam";
        Text = "EditExam";
        Load += EditExam_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label lbSubject;
    private ComboBox comboBox3;
    private TextBox txtExamName;
    private Label label2;
    private Label lbStatus;
    private ComboBox comboBox2;
    private TextBox txtDuration;
    private Label label3;
    private DateTimePicker dateTimePicker1;
    private Label label4;
    private Label lbType;
    private ComboBox comboBox1;
    private Button btnCancle;
    private Button btnSave;
}