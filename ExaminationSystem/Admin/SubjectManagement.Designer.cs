namespace ExaminationSystem.Admin;

partial class SubjectManagement
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
        dataGridView1 = new DataGridView();
        button1 = new Button();
        lbSubjectMng = new Label();
        btnBack = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.BorderStyle = BorderStyle.None;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.GridColor = SystemColors.HighlightText;
        dataGridView1.Location = new Point(1, 155);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(879, 400);
        dataGridView1.TabIndex = 6;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.Control;
        button1.Location = new Point(35, 108);
        button1.Name = "button1";
        button1.Size = new Size(185, 41);
        button1.TabIndex = 5;
        button1.Text = "Add Subject";
        button1.UseVisualStyleBackColor = false;
        // 
        // lbSubjectMng
        // 
        lbSubjectMng.AutoSize = true;
        lbSubjectMng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbSubjectMng.Location = new Point(269, 20);
        lbSubjectMng.MaximumSize = new Size(900, 600);
        lbSubjectMng.Name = "lbSubjectMng";
        lbSubjectMng.Size = new Size(331, 41);
        lbSubjectMng.TabIndex = 4;
        lbSubjectMng.Text = "Subjects Management";
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(35, 20);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(94, 29);
        btnBack.TabIndex = 7;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // SubjectManagement
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(btnBack);
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Controls.Add(lbSubjectMng);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "SubjectManagement";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SubjectManagement";
        Load += SubjectManagement_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Button button1;
    private Label lbSubjectMng;
    private Button btnBack;
}