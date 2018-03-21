using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CS3321_Project
{
    public partial class  frm_UserDetail : Form
    {
        public Database data;
        public string userID;
        private User user;
        private string userType;
        private ArrayList allCourses, allAssignments;

        public frm_UserDetail()
        {
            InitializeComponent();
        }

        private void frm_UserDetail_Load(object sender, EventArgs e)
        {
            
            //userType = user.getTypeOfUser();
            user = data.getUserInformation(userID);
            lblName.Text = user.getTypeOfUser() + ": " + user.getName();
            lblStudentID.Text = "ID: " + user.getID();
            allCourses = user.getAllCourseAsAList();
            MessageBox.Show(userType);

            if (userType.Equals("student", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < allCourses.Count; i++)
                {
                    StudentCourse stu = (StudentCourse)allCourses[i];
                    lstCoursesList.Items.Add(stu.getCourseName());
                }

            } else
            {
                Console.WriteLine("Professor");
                for (int i = 0; i < allCourses.Count; i++)
                {
                    ProfessorCourse stu = (ProfessorCourse)allCourses[i];
                    lstCoursesList.Items.Add(stu.getCourseName());
                }
            }

            
        }

        private void lstCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAssignments.Items.Clear();
            lstGrades.Items.Clear();
            StudentCourse selectedCourse = (StudentCourse)allCourses[lstCoursesList.SelectedIndex];
            allAssignments = selectedCourse.getAllAssignmentsAsAList();
            lblProfessor.Text = "Professor: " + selectedCourse.getProfessorName();

            for (int i = 0; i < allAssignments.Count; i++)
            {
                Assignment assign = (Assignment)allAssignments[i];
                lstAssignments.Items.Add(assign.getName() + "\t\t");
                lstGrades.Items.Add(assign.getGrade());
            }

        }
    }
}
