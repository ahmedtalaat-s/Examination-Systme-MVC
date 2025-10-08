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
            SubjectFilterationBox = new ComboBox();
            FilterationLB = new Label();
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
            // SubjectFilterationBox
            // 
            SubjectFilterationBox.FormattingEnabled = true;
            SubjectFilterationBox.Location = new Point(234, 137);
            SubjectFilterationBox.Name = "SubjectFilterationBox";
            SubjectFilterationBox.Size = new Size(183, 28);
            SubjectFilterationBox.TabIndex = 13;
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
            // StudentPracriceExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(FilterationLB);
            Controls.Add(SubjectFilterationBox);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "StudentPracriceExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPracriceExam";
            Load += StudentPracriceExam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private ComboBox SubjectFilterationBox;
        private Label FilterationLB;
    }
}