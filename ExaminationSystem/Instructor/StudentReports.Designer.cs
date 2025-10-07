namespace ExaminationSystem.Instructor;

partial class StudentReports
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
        lbStudentReport = new Label();
        btnBack = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // lbStudentReport
        // 
        lbStudentReport.AutoSize = true;
        lbStudentReport.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbStudentReport.Location = new Point(269, 33);
        lbStudentReport.MaximumSize = new Size(900, 600);
        lbStudentReport.Name = "lbStudentReport";
        lbStudentReport.Size = new Size(354, 60);
        lbStudentReport.TabIndex = 1;
        lbStudentReport.Text = "Student Reports";
        lbStudentReport.Click += lbStudentReport_Click;
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(40, 42);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(94, 29);
        btnBack.TabIndex = 10;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.GridColor = SystemColors.HighlightText;
        dataGridView1.Location = new Point(1, 161);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(881, 395);
        dataGridView1.TabIndex = 11;
        // 
        // StudentReports
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(dataGridView1);
        Controls.Add(btnBack);
        Controls.Add(lbStudentReport);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "StudentReports";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Reports";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbStudentReport;
    private Button btnBack;
    private DataGridView dataGridView1;
}