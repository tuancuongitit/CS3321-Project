namespace CS3321_Project
{
    partial class frm_UserDetail
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lstCoursesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lstGrades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 13);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(198, 13);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(66, 18);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "ID: 1112";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstCoursesList
            // 
            this.lstCoursesList.FormattingEnabled = true;
            this.lstCoursesList.ItemHeight = 19;
            this.lstCoursesList.Location = new System.Drawing.Point(22, 65);
            this.lstCoursesList.Name = "lstCoursesList";
            this.lstCoursesList.Size = new System.Drawing.Size(242, 118);
            this.lstCoursesList.TabIndex = 2;
            this.lstCoursesList.SelectedIndexChanged += new System.EventHandler(this.lstCoursesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Registered Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assignments";
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.ItemHeight = 19;
            this.lstAssignments.Location = new System.Drawing.Point(22, 226);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAssignments.Size = new System.Drawing.Size(179, 175);
            this.lstAssignments.TabIndex = 4;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(19, 189);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(67, 16);
            this.lblProfessor.TabIndex = 6;
            this.lblProfessor.Text = "Professor:";
            // 
            // lstGrades
            // 
            this.lstGrades.FormattingEnabled = true;
            this.lstGrades.ItemHeight = 19;
            this.lstGrades.Location = new System.Drawing.Point(200, 226);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstGrades.Size = new System.Drawing.Size(64, 175);
            this.lstGrades.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grades";
            // 
            // frm_UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAssignments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCoursesList);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_UserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.frm_UserDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ListBox lstCoursesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ListBox lstGrades;
        private System.Windows.Forms.Label label4;
    }
}