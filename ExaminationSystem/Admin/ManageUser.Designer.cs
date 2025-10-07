namespace ExaminationSystem.Admin
{
    partial class ManageUser
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
            lstStudent = new DataGridView();
            btnAddExam = new Button();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)lstStudent).BeginInit();
            SuspendLayout();
            // 
            // lstStudent
            // 
            lstStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStudent.BackgroundColor = SystemColors.Control;
            lstStudent.BorderStyle = BorderStyle.None;
            lstStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstStudent.GridColor = SystemColors.HighlightText;
            lstStudent.Location = new Point(12, 174);
            lstStudent.Name = "lstStudent";
            lstStudent.RowHeadersWidth = 51;
            lstStudent.Size = new Size(858, 361);
            lstStudent.TabIndex = 6;
            // 
            // btnAddExam
            // 
            btnAddExam.BackColor = SystemColors.HotTrack;
            btnAddExam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExam.ForeColor = SystemColors.Control;
            btnAddExam.Location = new Point(34, 127);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(185, 41);
            btnAddExam.TabIndex = 5;
            btnAddExam.Text = "Add User";
            btnAddExam.UseVisualStyleBackColor = false;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 18);
            label1.MaximumSize = new Size(900, 600);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 4;
            label1.Text = "User Management";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(34, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnBack);
            Controls.Add(lstStudent);
            Controls.Add(btnAddExam);
            Controls.Add(label1);
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            Load += ManageUser_Load;
            ((System.ComponentModel.ISupportInitialize)lstStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lstStudent;
        private Button btnAddExam;
        private Label label1;
        private Button btnBack;
    }
}