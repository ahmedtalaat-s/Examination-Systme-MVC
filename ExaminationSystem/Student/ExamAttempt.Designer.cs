namespace ExaminationSystem.Student
{
    partial class ExamAttempt
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
            FinishBtn = new Button();
            NextBtn = new Button();
            prevBtn = new Button();
            FExamPanel = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = SystemColors.ControlText;
            FinishBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinishBtn.ForeColor = SystemColors.Control;
            FinishBtn.Location = new Point(720, 489);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(113, 41);
            FinishBtn.TabIndex = 23;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = false;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = SystemColors.HotTrack;
            NextBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = SystemColors.Control;
            NextBtn.Location = new Point(720, 424);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(113, 41);
            NextBtn.TabIndex = 22;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = SystemColors.HotTrack;
            prevBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevBtn.ForeColor = SystemColors.Control;
            prevBtn.Location = new Point(34, 424);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(113, 41);
            prevBtn.TabIndex = 21;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = false;
            // 
            // FExamPanel
            // 
            FExamPanel.Location = new Point(12, 90);
            FExamPanel.Name = "FExamPanel";
            FExamPanel.Size = new Size(858, 306);
            FExamPanel.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 24);
            label1.Name = "label1";
            label1.Size = new Size(206, 46);
            label1.TabIndex = 24;
            label1.Text = "Exam Name";
            // 
            // ExamAttempt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(label1);
            Controls.Add(FinishBtn);
            Controls.Add(NextBtn);
            Controls.Add(prevBtn);
            Controls.Add(FExamPanel);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "ExamAttempt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamAttempt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinishBtn;
        private Button NextBtn;
        private Button prevBtn;
        private Panel FExamPanel;
        private Label label1;
    }
}