using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CS3321_Project
{
    public partial class frmProfessorDetail : Form
    {
        private Assignment allAssignments;
        private Course allCourses;
        private User allUsers;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private List<UserInfo> allStudentInfo = new List<UserInfo>();
        private UserInfo thisUserInfo;

        public frmProfessorDetail()
        {
            InitializeComponent();
        }

        public frmProfessorDetail(string username, User allUsers, Course allCourses, Assignment allAssignments)
        {
            InitializeComponent();
            lst_Course.ContextMenuStrip = mnuOnCourseList;
            lst_Assignment.ContextMenuStrip = mnuOnAssignmentList;
            mnuAddAssignment.Click += new EventHandler(mnuAddAssignment_Click);
            mnuDeleteThisAssignment.Click += new EventHandler(mnuDeleteAssignment_Click);
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void mnuAddAssignment_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            string assignmentName = Interaction.InputBox("Enter name", "");
            foreach (var stu in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                int randomID = rand.Next(20, 500000);
                allAssignments.addNewAssignment(allCourseInfo[lst_Course.SelectedIndex].id, stu.Key, randomID.ToString(), assignmentName);
                allUsers.addNewAssignment(allUsers.getInfoOfAUser(stu.Key, true).username, allCourseInfo[lst_Course.SelectedIndex].id, randomID.ToString());
                allCourses.addNewAssignment(allCourseInfo[lst_Course.SelectedIndex].id, stu.Key, randomID.ToString());
            }

            updateJsonFiles();
            lst_Course_SelectedIndexChanged(this, null);
        }

        private void mnuDeleteAssignment_Click(object sender, EventArgs e)
        {
            foreach (var stu in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                allUsers.deleteAssignment(allUsers.getInfoOfAUser(stu.Key, true).username, allCourseInfo[lst_Course.SelectedIndex].id, allAssignments.allAssignments[allCourseInfo[lst_Course.SelectedIndex].id].aStudentInfo[stu.Key].allAssignmentsOfAStudent.ElementAt(cbAssignmentBox.SelectedIndex).Key);
                allCourses.deleteAssignment(allCourseInfo[lst_Course.SelectedIndex].id, stu.Key, allAssignments.allAssignments[allCourseInfo[lst_Course.SelectedIndex].id].aStudentInfo[stu.Key].allAssignmentsOfAStudent.ElementAt(cbAssignmentBox.SelectedIndex).Key);
                allAssignments.deleteAssignment(allCourseInfo[lst_Course.SelectedIndex].id, cbAssignmentBox.SelectedItem.ToString(), allAssignments.allAssignments[allCourseInfo[lst_Course.SelectedIndex].id].aStudentInfo[stu.Key].allAssignmentsOfAStudent.ElementAt(cbAssignmentBox.SelectedIndex).Key, stu.Key);
            }

            updateJsonFiles();
            lst_Course_SelectedIndexChanged(this, null);
        }

        private void updateJsonFiles()
        {
            string json = JsonConvert.SerializeObject(allUsers, Formatting.Indented);
            //File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\usersDB.json", json);
            File.WriteAllText("usersDB.json", json);
            json = JsonConvert.SerializeObject(allCourses, Formatting.Indented);
            //File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\coursesDB.json", json);
            File.WriteAllText("coursesDB.json", json);
            json = JsonConvert.SerializeObject(allAssignments, Formatting.Indented);
            //File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\assignmentDB.json", json);
            File.WriteAllText("assignmentDB.json", json);
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
            lblStudentID.Text = "ID: " + user.id;
            if (user.allEnrolledCourses.Count > 1)
            {
                lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
            }
            else
            {
                lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " course";
            }
            
            lblTitle.Text = user.major;
            //get all enrolled courses
            loadEnrolledCourses(user);
        }

        private void loadEnrolledCourses(UserInfo user)
        {
            allCourseInfo.Clear();
            lst_Course.Items.Clear();
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
            lst_Assignment.SelectedIndex = lst_Student.SelectedIndex;
            lst_Grade.SelectedIndex = lst_Student.SelectedIndex;
        }

        private void lst_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAssignmentBox.Items.Clear();
            lst_Student.Items.Clear();
            lst_Assignment.Items.Clear();
            lst_Grade.Items.Clear();
            allStudentInfo.Clear();
            
            if (lst_Course.SelectedIndex != -1)
            {
                enrolledCourseInfo enrolled = thisUserInfo.allEnrolledCourses[allCourseInfo[lst_Course.SelectedIndex].id];

               foreach (string assignmentName in allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).totalAssignment)
                {
                    cbAssignmentBox.Items.Add(assignmentName);
                }

               if (allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).totalAssignment.Count > 0)
                {
                    cbAssignmentBox.SelectedIndex = 0;
                } else
                {
                    getAssignmentInfoList(-1);
                }
            }
        }

        private void getAssignmentInfoList(int index)
        {
            lst_Student.Items.Clear();
            lst_Assignment.Items.Clear();
            lst_Grade.Items.Clear();
            allStudentInfo.Clear();
            foreach (var pair in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                UserInfo user = allUsers.getInfoOfAUser(pair.Key, true);
                allStudentInfo.Add(user);
                lst_Student.Items.Add(user.name);

                if (index != -1)
                {
                    enrolledCourseInfo enroll = user.allEnrolledCourses[allCourseInfo[lst_Course.SelectedIndex].id];
                    AssignmentInfo assignment = allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).aStudentInfo[user.id].allAssignmentsOfAStudent[(string)enroll.assignmentIDList[index]];
                    lst_Assignment.Items.Add(assignment.name);
                    lst_Grade.Items.Add(assignment.grade);
                }

            }
        }

        private void cbAssignmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAssignmentInfoList(cbAssignmentBox.SelectedIndex);
        }

        private void lst_Assignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_Student.SelectedIndex = lst_Assignment.SelectedIndex;
            lst_Grade.SelectedIndex = lst_Assignment.SelectedIndex;
        }

        private void lst_Grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_Assignment.SelectedIndex = lst_Grade.SelectedIndex;
            lst_Student.SelectedIndex = lst_Grade.SelectedIndex;
        }

        private void lst_Grade_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var inputGrade = Interaction.InputBox("Enter grade for this assignment", "", "-1");

            if (!inputGrade.Equals(""))
            {
                var newGrade = Convert.ToInt64(inputGrade);

                if (newGrade != -1)
                {
                    allAssignments.updateAssignment(allCourseInfo[lst_Course.SelectedIndex].id, allStudentInfo[lst_Student.SelectedIndex].id, allAssignments.allAssignments[allCourseInfo[lst_Course.SelectedIndex].id].aStudentInfo[allStudentInfo[lst_Student.SelectedIndex].id].allAssignmentsOfAStudent.ElementAt(cbAssignmentBox.SelectedIndex).Key, newGrade);
                    updateJsonFiles();
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText("usersDB.json");
            allUsers = JsonConvert.DeserializeObject<User>(json);
            json = File.ReadAllText("coursesDB.json");
            allCourses = JsonConvert.DeserializeObject<Course>(json);
            json = File.ReadAllText("assignmentDB.json");
            allAssignments = JsonConvert.DeserializeObject<Assignment>(json);
            loadUserInfo();
        }
    }
}
