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
        private User allUsers;
        private Course allCourses;
        private Assignment allAssignments;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private UserInfo thisUserInfo;

        public frm_UserDetail()
        {
            InitializeComponent();
        }

        public frm_UserDetail(string username, User allusers, Course allCourse, Assignment allAssignments)
        {
            InitializeComponent();
            this.Width = 279;
            this.username = username;
            this.allUsers = allusers;
            this.allCourses = allCourse;
            this.allAssignments = allAssignments;
        }

        private void frm_UserDetail_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            UserInfo user = allUsers.getInfoOfAUser(username);
            thisUserInfo = user;
            lblName.Text = user.name;
            lblStudentID.Text = "ID: " + user.id;
            lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
            lblMajor.Text = user.major;
            //get all enrolled courses
            loadEnrolledCourses(user);
        }

        private void loadEnrolledCourses(UserInfo user)
        {
            foreach (var pair in user.allEnrolledCourses)
            {
                var courseID = pair.Key;
                CourseInfo course = allCourses.getInfoOfACourse(courseID);
                allCourseInfo.Add(course);
                var courseName = course.name;
                lstCoursesList.Items.Add(courseName);
            }
        }

        private void lstCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Width = 557;
            lblCourseName.Text = allCourseInfo[lstCoursesList.SelectedIndex].name;
            lblCourseID.Text = allCourseInfo[lstCoursesList.SelectedIndex].id;
            lblProfessor.Text = allCourseInfo[lstCoursesList.SelectedIndex].professor;
            lblCourseType.Text = allCourseInfo[lstCoursesList.SelectedIndex].type;

            loadAssignments();
        }

        private void loadAssignments()
        {
            int i = 0;

            enrolledCourseInfo enrolled = thisUserInfo.allEnrolledCourses[allCourseInfo[lstCoursesList.SelectedIndex].id];              

            foreach (string id in enrolled.assignmentIDList)
            {
                AssignmentInfo assignment = allAssignments.getInfoOfAAssignment(id);
                lstAssignmentList.Items.Add(assignment.name);
                lstGrade.Items.Add(assignment.grade);
            }
        }

        private void lstAssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstGrade.SelectedIndex = lstAssignmentList.SelectedIndex;
        }

        private void lstGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAssignmentList.SelectedIndex = lstGrade.SelectedIndex;
        }
    }
}
