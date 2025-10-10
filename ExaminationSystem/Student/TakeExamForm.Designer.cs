namespace ExaminationSystem.Student
{
    partial class TakeExamForm
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
            lblQuestionNumber = new Label();
            lblQuestionBody = new Label();
            flowChoices = new FlowLayoutPanel();
            btnSubmit = new Button();
            btnNext = new Button();
            lblFeedback = new Label();
            lblScore = new Label();
            lbqHeader = new Label();
            lbMarks = new Label();
            SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(36, 27);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(50, 20);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "label1";
            // 
            // lblQuestionBody
            // 
            lblQuestionBody.AutoSize = true;
            lblQuestionBody.Location = new Point(36, 135);
            lblQuestionBody.Name = "lblQuestionBody";
            lblQuestionBody.Size = new Size(50, 20);
            lblQuestionBody.TabIndex = 1;
            lblQuestionBody.Text = "label1";
            // 
            // flowChoices
            // 
            flowChoices.AutoScroll = true;
            flowChoices.AutoSize = true;
            flowChoices.Location = new Point(45, 170);
            flowChoices.MaximumSize = new Size(700, 0);
            flowChoices.Name = "flowChoices";
            flowChoices.Size = new Size(250, 0);
            flowChoices.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(558, 390);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(681, 390);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(51, 372);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(50, 20);
            lblFeedback.TabIndex = 5;
            lblFeedback.Text = "label1";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(652, 36);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(65, 20);
            lblScore.TabIndex = 6;
            lblScore.Text = "Score : 0";
            // 
            // lbqHeader
            // 
            lbqHeader.AutoSize = true;
            lbqHeader.Location = new Point(36, 80);
            lbqHeader.Name = "lbqHeader";
            lbqHeader.Size = new Size(50, 20);
            lbqHeader.TabIndex = 7;
            lbqHeader.Text = "label1";
            // 
            // lbMarks
            // 
            lbMarks.AutoSize = true;
            lbMarks.Location = new Point(652, 80);
            lbMarks.Name = "lbMarks";
            lbMarks.Size = new Size(50, 20);
            lbMarks.TabIndex = 8;
            lbMarks.Text = "label1";
            // 
            // TakeExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMarks);
            Controls.Add(lbqHeader);
            Controls.Add(lblScore);
            Controls.Add(lblFeedback);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(flowChoices);
            Controls.Add(lblQuestionBody);
            Controls.Add(lblQuestionNumber);
            Name = "TakeExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TakeExamForm";
            Load += TakeExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionNumber;
        private Label lblQuestionBody;
        private FlowLayoutPanel flowChoices;
        private Button btnSubmit;
        private Button btnNext;
        private Label lblFeedback;
        private Label lblScore;
        private Label lbqHeader;
        private Label lbMarks;
    }
}