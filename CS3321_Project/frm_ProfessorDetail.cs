using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3321_Project
{
    public partial class frmProfessorDetail : Form
    {
        private Assignment allAssignments;
        private Course allCourses;
        private User allUsers;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private UserInfo thisUserInfo;

        public frmProfessorDetail()
        {
            InitializeComponent();
        }

        public frmProfessorDetail(string username, User allUsers, Course allCourses, Assignment allAssignments)
        {
            InitializeComponent();
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void frmProfessorDetail_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            loadUserInfo(); 
        }

        private void loadUserInfo()
        {
            UserInfo user = allUsers.getInfoOfAUser(username, false);
            thisUserInfo = user;
            lblName.Text = user.name;
            lblStudentID.Text = "ID: " + user.id;
            lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
            lblTitle.Text = user.major;
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
                lst_Course.Items.Add(courseName);
            }
        }

        private void frmProfessorDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void lst_StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Course.SelectedIndex != -1)
            {
                enrolledCourseInfo enrolled = thisUserInfo.allEnrolledCourses[allCourseInfo[lst_Course.SelectedIndex].id];

                foreach (string id in enrolled.assignmentIDList)
                {
                    AssignmentInfo assignment = allAssignments.getInfoOfAAssignment(id);
                    cbAssignmentBox.Items.Add(assignment.name);
                }
                cbAssignmentBox.SelectedIndex = 0;
                getAssignmentInfoList(cbAssignmentBox.SelectedIndex);
            }
        }

        private void getAssignmentInfoList(int index)
        {
            lst_Student.Items.Clear();
            lst_Assignment.Items.Clear();
            lst_Grade.Items.Clear();
            foreach (var pair in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                UserInfo user = allUsers.getInfoOfAUser(pair.Key, true);
                lst_Student.Items.Add(user.name);

                enrolledCourseInfo enroll = user.allEnrolledCourses[allCourseInfo[lst_Course.SelectedIndex].id];
                AssignmentInfo assignment = allAssignments.getInfoOfAAssignment((string)enroll.assignmentIDList[index]);
                lst_Assignment.Items.Add(assignment.name);
                lst_Grade.Items.Add(assignment.grade);

            }
        }

        private void cbAssignmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAssignmentInfoList(cbAssignmentBox.SelectedIndex);
        }
    }
}
