namespace CS3321_Project
{
    partial class frm_Admin
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Professor = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_Student = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Course = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_Professor = new System.Windows.Forms.ListBox();
            this.tab_Student = new System.Windows.Forms.TabPage();
            this.mnu_OnStudentList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tab_Professor.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mnu_OnStudentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Professor);
            this.tabControl1.Controls.Add(this.tab_Student);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 326);
            this.tabControl1.TabIndex = 16;
            // 
            // tab_Professor
            // 
            this.tab_Professor.Controls.Add(this.groupBox4);
            this.tab_Professor.Controls.Add(this.groupBox1);
            this.tab_Professor.Controls.Add(this.groupBox3);
            this.tab_Professor.Controls.Add(this.groupBox2);
            this.tab_Professor.Location = new System.Drawing.Point(4, 22);
            this.tab_Professor.Name = "tab_Professor";
            this.tab_Professor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Professor.Size = new System.Drawing.Size(627, 300);
            this.tab_Professor.TabIndex = 0;
            this.tab_Professor.Text = "Professor";
            this.tab_Professor.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_Student);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(431, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 285);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student";
            // 
            // lst_Student
            // 
            this.lst_Student.FormattingEnabled = true;
            this.lst_Student.ItemHeight = 16;
            this.lst_Student.Location = new System.Drawing.Point(11, 19);
            this.lst_Student.Name = "lst_Student";
            this.lst_Student.Size = new System.Drawing.Size(163, 260);
            this.lst_Student.TabIndex = 3;
            this.lst_Student.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_Student_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Course);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 181);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course";
            // 
            // lst_Course
            // 
            this.lst_Course.FormattingEnabled = true;
            this.lst_Course.ItemHeight = 16;
            this.lst_Course.Location = new System.Drawing.Point(11, 19);
            this.lst_Course.Name = "lst_Course";
            this.lst_Course.Size = new System.Drawing.Size(220, 148);
            this.lst_Course.TabIndex = 3;
            this.lst_Course.SelectedIndexChanged += new System.EventHandler(this.lst_Course_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTitle);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblTotalCourses);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblStudentID);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(184, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(63, 68);
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
            this.label9.Location = new System.Drawing.Point(8, 68);
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
            this.lblTotalCourses.Location = new System.Drawing.Point(155, 43);
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
            this.label3.Location = new System.Drawing.Point(8, 44);
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
            this.lblStudentID.Location = new System.Drawing.Point(165, 18);
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
            this.lblName.Location = new System.Drawing.Point(7, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Cuong Pham";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Professor);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 287);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // lst_Professor
            // 
            this.lst_Professor.FormattingEnabled = true;
            this.lst_Professor.ItemHeight = 16;
            this.lst_Professor.Location = new System.Drawing.Point(6, 19);
            this.lst_Professor.Name = "lst_Professor";
            this.lst_Professor.Size = new System.Drawing.Size(160, 260);
            this.lst_Professor.TabIndex = 3;
            this.lst_Professor.SelectedIndexChanged += new System.EventHandler(this.lst_Professor_SelectedIndexChanged);
            // 
            // tab_Student
            // 
            this.tab_Student.Location = new System.Drawing.Point(4, 22);
            this.tab_Student.Name = "tab_Student";
            this.tab_Student.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Student.Size = new System.Drawing.Size(627, 300);
            this.tab_Student.TabIndex = 1;
            this.tab_Student.Text = "Student";
            this.tab_Student.UseVisualStyleBackColor = true;
            // 
            // mnu_OnStudentList
            // 
            this.mnu_OnStudentList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete});
            this.mnu_OnStudentList.Name = "contextMenuStrip1";
            this.mnu_OnStudentList.Size = new System.Drawing.Size(168, 48);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(167, 22);
            this.mnuAdd.Text = "Add New Student";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(167, 22);
            this.mnuDelete.Text = "Delete";
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 325);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.frm_Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Professor.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.mnu_OnStudentList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Professor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Course;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Professor;
        private System.Windows.Forms.TabPage tab_Student;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_Student;
        private System.Windows.Forms.ContextMenuStrip mnu_OnStudentList;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}