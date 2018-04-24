namespace CS3321_Project
{
    partial class frmProfessorDetail
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_Course = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAssignmentBox = new System.Windows.Forms.ComboBox();
            this.lst_Grade = new System.Windows.Forms.ListBox();
            this.lst_Assignment = new System.Windows.Forms.ListBox();
            this.lst_Student = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Course);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 181);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Courses";
            // 
            // lst_Course
            // 
            this.lst_Course.FormattingEnabled = true;
            this.lst_Course.ItemHeight = 16;
            this.lst_Course.Location = new System.Drawing.Point(11, 21);
            this.lst_Course.Name = "lst_Course";
            this.lst_Course.Size = new System.Drawing.Size(220, 148);
            this.lst_Course.TabIndex = 3;
            this.lst_Course.SelectedIndexChanged += new System.EventHandler(this.lst_Course_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTotalCourses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(63, 70);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 19);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Computer Science";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Title:";
            // 
            // lblTotalCourses
            // 
            this.lblTotalCourses.AutoSize = true;
            this.lblTotalCourses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCourses.Location = new System.Drawing.Point(155, 45);
            this.lblTotalCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCourses.Name = "lblTotalCourses";
            this.lblTotalCourses.Size = new System.Drawing.Size(76, 19);
            this.lblTotalCourses.TabIndex = 5;
            this.lblTotalCourses.Text = "4 courses";
            this.lblTotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teaching:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(165, 20);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(66, 18);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "ID: 1112";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 19);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Cuong Pham";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbAssignmentBox);
            this.groupBox3.Controls.Add(this.lst_Grade);
            this.groupBox3.Controls.Add(this.lst_Assignment);
            this.groupBox3.Controls.Add(this.lst_Student);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(264, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 287);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Students";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(292, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAssignmentBox
            // 
            this.cbAssignmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignmentBox.FormattingEnabled = true;
            this.cbAssignmentBox.Location = new System.Drawing.Point(164, 22);
            this.cbAssignmentBox.Name = "cbAssignmentBox";
            this.cbAssignmentBox.Size = new System.Drawing.Size(111, 24);
            this.cbAssignmentBox.TabIndex = 6;
            this.cbAssignmentBox.SelectedIndexChanged += new System.EventHandler(this.cbAssignmentBox_SelectedIndexChanged);
            // 
            // lst_Grade
            // 
            this.lst_Grade.FormattingEnabled = true;
            this.lst_Grade.ItemHeight = 16;
            this.lst_Grade.Location = new System.Drawing.Point(274, 47);
            this.lst_Grade.Name = "lst_Grade";
            this.lst_Grade.Size = new System.Drawing.Size(82, 228);
            this.lst_Grade.TabIndex = 5;
            // 
            // lst_Assignment
            // 
            this.lst_Assignment.FormattingEnabled = true;
            this.lst_Assignment.ItemHeight = 16;
            this.lst_Assignment.Location = new System.Drawing.Point(164, 47);
            this.lst_Assignment.Name = "lst_Assignment";
            this.lst_Assignment.Size = new System.Drawing.Size(111, 228);
            this.lst_Assignment.TabIndex = 4;
            // 
            // lst_Student
            // 
            this.lst_Student.FormattingEnabled = true;
            this.lst_Student.ItemHeight = 16;
            this.lst_Student.Location = new System.Drawing.Point(13, 47);
            this.lst_Student.Name = "lst_Student";
            this.lst_Student.Size = new System.Drawing.Size(154, 228);
            this.lst_Student.TabIndex = 3;
            this.lst_Student.SelectedIndexChanged += new System.EventHandler(this.lst_StudentList_SelectedIndexChanged);
            // 
            // frmProfessorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 309);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProfessorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProfessorDetail_FormClosing);
            this.Load += new System.EventHandler(this.frmProfessorDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Course;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_Student;
        private System.Windows.Forms.ListBox lst_Grade;
        private System.Windows.Forms.ListBox lst_Assignment;
        private System.Windows.Forms.ComboBox cbAssignmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}