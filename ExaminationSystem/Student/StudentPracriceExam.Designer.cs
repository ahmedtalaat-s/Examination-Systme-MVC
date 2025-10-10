namespace ExaminationSystem.Student
{
    partial class StudentPracriceExam
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
            cmbSubjects = new ComboBox();
            FilterationLB = new Label();
            dgvExams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 23);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbSubjectMng
            // 
            lbSubjectMng.AutoSize = true;
            lbSubjectMng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubjectMng.Location = new Point(332, 11);
            lbSubjectMng.MaximumSize = new Size(900, 600);
            lbSubjectMng.Name = "lbSubjectMng";
            lbSubjectMng.Size = new Size(213, 41);
            lbSubjectMng.TabIndex = 10;
            lbSubjectMng.Text = "Practice Exam";
            // 
            // cmbSubjects
            // 
            cmbSubjects.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(212, 134);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(203, 39);
            cmbSubjects.TabIndex = 13;
            cmbSubjects.SelectedIndexChanged += cmbSubjects_SelectedIndexChanged;
            // 
            // FilterationLB
            // 
            FilterationLB.AutoSize = true;
            FilterationLB.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterationLB.Location = new Point(12, 134);
            FilterationLB.Name = "FilterationLB";
            FilterationLB.Size = new Size(194, 31);
            FilterationLB.TabIndex = 14;
            FilterationLB.Text = "Filter By Subject";
            // 
            // dgvExams
            // 
            dgvExams.BackgroundColor = SystemColors.Control;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(-1, 225);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.Size = new Size(882, 328);
            dgvExams.TabIndex = 15;
            dgvExams.CellContentClick += dgvExams_CellContentClick;
            // 
            // StudentPracriceExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvExams);
            Controls.Add(FilterationLB);
            Controls.Add(cmbSubjects);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "StudentPracriceExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPracriceExam";
            Load += StudentPracriceExam_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private ComboBox cmbSubjects;
        private Label FilterationLB;
        private DataGridView dgvExams;
    }
}