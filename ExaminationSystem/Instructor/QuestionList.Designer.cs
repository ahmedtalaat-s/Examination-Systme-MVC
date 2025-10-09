namespace ExaminationSystem.Instructor;

partial class QuestionList
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
        button1 = new Button();
        label1 = new Label();
        btnBack = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.ForeColor = Color.White;
        button1.Location = new Point(31, 135);
        button1.Name = "button1";
        button1.Size = new Size(185, 41);
        button1.TabIndex = 4;
        button1.Text = "Add Question";
        button1.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(242, 23);
        label1.MaximumSize = new Size(900, 600);
        label1.Name = "label1";
        label1.Size = new Size(353, 41);
        label1.TabIndex = 3;
        label1.Text = "Questions Management";
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(31, 23);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(94, 29);
        btnBack.TabIndex = 9;
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
        dataGridView1.Location = new Point(1, 182);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(881, 371);
        dataGridView1.TabIndex = 10;
        // 
        // QuestionList
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 553);
        Controls.Add(dataGridView1);
        Controls.Add(btnBack);
        Controls.Add(button1);
        Controls.Add(label1);
        MaximizeBox = false;
        MaximumSize = new Size(900, 600);
        MinimumSize = new Size(900, 600);
        Name = "QuestionList";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Question List";
        Load += QuestionList_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Button btnBack;
    private DataGridView dataGridView1;
}