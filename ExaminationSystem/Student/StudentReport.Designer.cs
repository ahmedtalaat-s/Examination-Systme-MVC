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
            ReportsGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ReportsGV).BeginInit();
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
            // ReportsGV
            // 
            ReportsGV.BackgroundColor = SystemColors.Control;
            ReportsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsGV.Location = new Point(3, 228);
            ReportsGV.Name = "ReportsGV";
            ReportsGV.RowHeadersWidth = 51;
            ReportsGV.Size = new Size(878, 324);
            ReportsGV.TabIndex = 10;
            // 
            // StudentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(ReportsGV);
            Controls.Add(btnBack);
            Controls.Add(lbSubjectMng);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "StudentReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentReport";
            ((System.ComponentModel.ISupportInitialize)ReportsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lbSubjectMng;
        private DataGridView ReportsGV;
    }
}