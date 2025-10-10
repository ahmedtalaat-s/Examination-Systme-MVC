namespace ExaminationSystem.Student
{
    partial class StudentReport
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
            btnBack = new Button();
            lbSubjectMng = new Label();
            dgvReports = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbSubjectMng
            // 
            lbSubjectMng.AutoSize = true;
            lbSubjectMng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubjectMng.Location = new Point(285, 13);
            lbSubjectMng.MaximumSize = new Size(900, 600);
            lbSubjectMng.Name = "lbSubjectMng";
            lbSubjectMng.Size = new Size(247, 41);
            lbSubjectMng.TabIndex = 8;
            lbSubjectMng.Text = "Student Reports";
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = SystemColors.Control;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(0, 161);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(881, 391);
            dgvReports.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(776, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRefresh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(659, 114);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDownloadPdf_Click;
            // 
            // StudentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvReports);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "StudentReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentReport";
            Load += StudentReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private DataGridView dgvReports;
        private Button button1;
        private Button button2;
    }
}