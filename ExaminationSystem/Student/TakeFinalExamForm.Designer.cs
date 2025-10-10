namespace ExaminationSystem.Student
{
    partial class TakeFinalExamForm
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
            lblTimer = new Label();
            lblQuestionNumber = new Label();
            lblQuestionBody = new Label();
            flowChoices = new FlowLayoutPanel();
            btnPrev = new Button();
            btnNext = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(605, 28);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(50, 20);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "label1";
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(25, 28);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(50, 20);
            lblQuestionNumber.TabIndex = 1;
            lblQuestionNumber.Text = "label1";
            // 
            // lblQuestionBody
            // 
            lblQuestionBody.AutoSize = true;
            lblQuestionBody.Location = new Point(25, 145);
            lblQuestionBody.Name = "lblQuestionBody";
            lblQuestionBody.Size = new Size(50, 20);
            lblQuestionBody.TabIndex = 2;
            lblQuestionBody.Text = "label1";
            // 
            // flowChoices
            // 
            flowChoices.Location = new Point(25, 214);
            flowChoices.Name = "flowChoices";
            flowChoices.Size = new Size(250, 125);
            flowChoices.TabIndex = 3;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(25, 409);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(667, 409);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(667, 359);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // TakeFinalExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(flowChoices);
            Controls.Add(lblQuestionBody);
            Controls.Add(lblQuestionNumber);
            Controls.Add(lblTimer);
            Name = "TakeFinalExamForm";
            Text = "TakeFinalExamForm";
            FormClosing += TakeFinalExamForm_FormClosing;
            Load += TakeFinalExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Label lblQuestionNumber;
        private Label lblQuestionBody;
        private FlowLayoutPanel flowChoices;
        private Button btnPrev;
        private Button btnNext;
        private Button btnSubmit;
    }
}