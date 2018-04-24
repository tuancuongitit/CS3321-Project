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
        private UserInfo thisUserInfo;

        public frm_Admin()
        {
            InitializeComponent();
        }

        public frm_Admin(string username, User allUsers, Course allCourses, Assignment allAssignments)
        {
            InitializeComponent();
            lst_Student.ContextMenuStrip = mnu_OnStudentList;
            mnuAdd.Click += new EventHandler(mnuAdd_Click);
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            var arr = new ArrayList();
            arr.Add("5");
            arr.Add("6");
            allUsers.addNewUser("11111", "Louis", "lm3", "999", "Accounting", "Student", "CS_3306", arr);
            allCourses.updateACourse(allCourseInfo[lst_Course.SelectedIndex].id, "11111", arr);
            string json = JsonConvert.SerializeObject(allUsers, Formatting.Indented);
            File.WriteAllText(@"\\Mac\Home\Desktop\OneDrive\University\Active Spring 2018\CS 3321 Software Engineering\Project\ForkSource\CS3321_Project\usersDB.json", json);
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadAllProfessors();
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
            loadUserInfo(allProfessorInfo[lst_Professor.SelectedIndex].username);
        }

        private void loadUserInfo(string username)
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

        private void lst_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var pair in allCourseInfo[lst_Course.SelectedIndex].allEnrolledStudent)
            {
                UserInfo user = allUsers.getInfoOfAUser(pair.Key, true);
                lst_Student.Items.Add(user.name);
            }
        }

        private void lst_Student_MouseDown(object sender, MouseEventArgs e)
        {
            lst_Student.SelectedIndex = lst_Student.IndexFromPoint(e.X, e.Y);
        }
    }
}
