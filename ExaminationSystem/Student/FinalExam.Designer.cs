namespace ExaminationSystem.Student
{
    partial class FinalExam
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
            dgvExams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(30, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // lbSubjectMng
            // 
            lbSubjectMng.AutoSize = true;
            lbSubjectMng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubjectMng.Location = new Point(341, 32);
            lbSubjectMng.MaximumSize = new Size(900, 600);
            lbSubjectMng.Name = "lbSubjectMng";
            lbSubjectMng.Size = new Size(170, 41);
            lbSubjectMng.TabIndex = 12;
            lbSubjectMng.Text = "Final Exam";
            // 
            // dgvExams
            // 
            dgvExams.BackgroundColor = SystemColors.Control;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(12, 135);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.Size = new Size(858, 406);
            dgvExams.TabIndex = 14;
            // 
            // FinalExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvExams);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimizeBox = false;
            MinimumSize = new Size(900, 600);
            Name = "FinalExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalExam";
            Load += StudentFinalExamList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private DataGridView dgvExams;
    }
}