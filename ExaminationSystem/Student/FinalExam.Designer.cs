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
            FExamPanel = new Panel();
            prevBtn = new Button();
            NextBtn = new Button();
            FinishBtn = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lbSubjectMng
            // 
            lbSubjectMng.AutoSize = true;
            lbSubjectMng.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubjectMng.Location = new Point(342, 9);
            lbSubjectMng.MaximumSize = new Size(900, 600);
            lbSubjectMng.Name = "lbSubjectMng";
            lbSubjectMng.Size = new Size(170, 41);
            lbSubjectMng.TabIndex = 12;
            lbSubjectMng.Text = "Final Exam";
            // 
            // FExamPanel
            // 
            FExamPanel.Location = new Point(5, 154);
            FExamPanel.Name = "FExamPanel";
            FExamPanel.Size = new Size(874, 248);
            FExamPanel.TabIndex = 15;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = SystemColors.HotTrack;
            prevBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevBtn.ForeColor = SystemColors.Control;
            prevBtn.Location = new Point(45, 420);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(113, 41);
            prevBtn.TabIndex = 17;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = false;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = SystemColors.HotTrack;
            NextBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = SystemColors.Control;
            NextBtn.Location = new Point(737, 420);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(113, 41);
            NextBtn.TabIndex = 18;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = SystemColors.HotTrack;
            FinishBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinishBtn.ForeColor = SystemColors.Control;
            FinishBtn.Location = new Point(737, 500);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(113, 41);
            FinishBtn.TabIndex = 19;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = false;
            // 
            // FinalExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(FinishBtn);
            Controls.Add(NextBtn);
            Controls.Add(prevBtn);
            Controls.Add(FExamPanel);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "FinalExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalExam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private Panel FExamPanel;
        private Button prevBtn;
        private Button NextBtn;
        private Button FinishBtn;
    }
}