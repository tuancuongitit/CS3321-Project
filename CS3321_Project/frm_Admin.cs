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
using Newtonsoft.Json;
using System.IO;

namespace CS3321_Project
{
    public partial class frm_Admin : Form
    {
        private Assignment allAssignments;
        private Course allCourses;
        private User allUsers;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private List<UserInfo> allProfessorInfo = new List<UserInfo>();
        private List<UserInfo> allManageStudentInfo = new List<UserInfo>();
        private List<UserInfo> allStudentInfo = new List<UserInfo>();
        private UserInfo thisUserInfo;

        public frm_Admin()
        {
            InitializeComponent();
        }

        public frm_Admin(string username, User allUsers, Course allCourses, Assignment allAssignments)
        {
            InitializeComponent();
            lst_Student.ContextMenuStrip = mnu_OnStudentList;
            lst_Course.ContextMenuStrip = mnu_OnCourseList;
            mnuAdd.Click += new EventHandler(mnuAddStudent_Click);
            mnuDelete.Click += new EventHandler(mnuDeleteStudent_Click);
            mnuAddCourse.Click += new EventHandler(mnuAddCourse_Click);
            mnuDeleteCourse.Click += new EventHandler(mnuDeleteCourse_Click);
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void mnuAddCourse_Click(object sender, EventArgs e)
        {
            allCourses.addNewCourse("CS_1111", "Visual Basic", "Harris Tom", "Regular");
            allUsers.addNewCourse("CS_1111", allProfessorInfo[lst_Professor.SelectedIndex].username);
            allAssignments.addNewCourse("CS_1111");
            updateJsonFiles();
        }

        private void mnuDeleteCourse_Click(object sender, EventArgs e)
        {
            allCourses.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            allUsers.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            allAssignments.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            updateJsonFiles();
        }

        private void mnuAddStudent_Click(object sender, EventArgs e)
        {
            var arr = new ArrayList();
            var rand = new Random();
            foreach (var totalAssignment in allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).totalAssignment)
            {
                int randomID = rand.Next(20, 500000);
                arr.Add(randomID.ToString());
            }

            allUsers.addNewUser("1113", "Kevin", "kv", "999", "Accounting", "Student", "CS_3306", arr);
            allCourses.updateACourse(allCourseInfo[lst_Course.SelectedIndex].id, "1113", arr);
            allAssignments.updateAssignmentOfACourse(allCourseInfo[lst_Course.SelectedIndex].id, "1113", arr);

            updateJsonFiles();
            lst_Course.Select();
        }

        private void mnuDeleteStudent_Click(object sender, EventArgs e)
        {
            allUsers.deleteAUser(allStudentInfo[lst_Student.SelectedIndex].username);
            allCourses.deleteAUserInACourse(allCourseInfo[lst_Course.SelectedIndex].id, allStudentInfo[lst_Student.SelectedIndex].id);
            allAssignments.deleteAUser(allCourseInfo[lst_Course.SelectedIndex].id, allStudentInfo[lst_Student.SelectedIndex].id);
            updateJsonFiles();
        }

        private void updateJsonFiles()
        {
            string json = JsonConvert.SerializeObject(allUsers, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\usersDB.json", json);
            json = JsonConvert.SerializeObject(allCourses, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\coursesDB.json", json);
            json = JsonConvert.SerializeObject(allAssignments, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\assignmentDB.json", json);
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadAllProfessors();
            LoadAllStudents();
        }

        private void LoadAllProfessors()
        {
            foreach (var pair in allUsers.allUsers)
            {
                if (allUsers.getTypeOfAUser(pair.Value.username).Equals("Professor"))
                {
                    allProfessorInfo.Add(allUsers.allUsers[pair.Value.username]);
                    lst_Professor.Items.Add(pair.Value.name);
                }
            }
        }
        
        private void lst_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUserInfo(allProfessorInfo[lst_Professor.SelectedIndex].username, "Professor");
        }

        private void loadUserInfo(string username, string userType)
        {
            UserInfo user = allUsers.getInfoOfAUser(username, false);
            thisUserInfo = user;

            if (userType.Equals("Professor"))
            {
                lblName.Text = user.name;
                lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
                lblProfessorID.Text = "ID: " + user.id;
                lblTitle.Text = user.major;
            } else
            {
                lblStudentName.Text = user.name;
                lblTotalStudentCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
                lblStudentID.Text = "ID: " + user.id;
                lblMajor.Text = user.major;
            }
            
            //get all enrolled courses
            loadEnrolledCourses(user, userType);
        }

        private void loadEnrolledCourses(UserInfo user, string userType)
        {
            allCourseInfo.Clear();
            lst_Course.Items.Clear();
            lst_ManageStudentCourse.Items.Clear();
            foreach (var pair in user.allEnrolledCourses)
            {
                var courseID = pair.Key;
                CourseInfo course = allCourses.getInfoOfACourse(courseID);
                allCourseInfo.Add(course);
                var courseName = course.name;

                if (userType.Equals("Professor"))
                {
                    lst_Course.Items.Add(courseName);
                } else
                {
                    lst_ManageStudentCourse.Items.Add(courseName);
                }
                
            }
        }

        private void lst_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            allStudentInfo.Clear();
            lst_Student.Items.Clear();
            foreach (var pair in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                UserInfo user = allUsers.getInfoOfAUser(pair.Key, true);
                allStudentInfo.Add(user);
                lst_Student.Items.Add(user.name);
            }
        }

        private void lst_Student_MouseDown(object sender, MouseEventArgs e)
        {
            lst_Student.SelectedIndex = lst_Student.IndexFromPoint(e.X, e.Y);
        }

        //for user management
        private void LoadAllStudents()
        {
            foreach (var pair in allUsers.allUsers)
            {
                if (allUsers.getTypeOfAUser(pair.Value.username).Equals("Student"))
                {
                    allManageStudentInfo.Add(allUsers.allUsers[pair.Value.username]);
                    lst_ManageStudent.Items.Add(pair.Value.name);
                }
            }
        }

        private void lst_ManageStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUserInfo(allManageStudentInfo[lst_ManageStudent.SelectedIndex].username, "Student");
        }
    }
}
