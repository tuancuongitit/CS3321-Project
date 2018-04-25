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
using Microsoft.VisualBasic;

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
            lst_Professor.ContextMenuStrip = mnu_OnProfessList;
            mnuAdd.Click += new EventHandler(mnuAddStudent_Click);
            mnuDelete.Click += new EventHandler(mnuDeleteStudent_Click);
            mnuAddCourse.Click += new EventHandler(mnuAddCourse_Click);
            mnuDeleteCourse.Click += new EventHandler(mnuDeleteCourse_Click);
            mnuAddProfessor.Click += new EventHandler(mnuAddProfessor_Click);
            mnuDeleteProfessor.Click += new EventHandler(mnuDeleteProfessor_Click);
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void mnuAddProfessor_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var ipUsername = Interaction.InputBox("Enter username", "", "");
            var generateID = rand.Next(200, 20000);
            if (!ipUsername.Equals(""))
            {
                var ipPassword = Interaction.InputBox("Enter password", "", "");
                if (!ipPassword.Equals(""))
                {
                    var ipName = Interaction.InputBox("Enter full name", "", "");
                    if (!ipName.Equals(""))
                    {
                        var ipTitle = Interaction.InputBox("Enter title", "", "");
                        allUsers.addNewUser(generateID.ToString(), ipName, ipUsername, ipPassword, ipTitle, "Professor", "", new ArrayList());
                    }
                }
            }

            updateJsonFiles();
            LoadAllProfessors(); //reload
        }

        public void mnuDeleteProfessor_Click(object sender, EventArgs e)
        {
            foreach (var pair in allProfessorInfo[lst_Professor.SelectedIndex].allEnrolledCourses)
            {
                allAssignments.deleteAProfessor(pair.Key);
                allCourses.deleteAProfessor(pair.Key);
            }
            allUsers.deleteAUser(allProfessorInfo[lst_Professor.SelectedIndex].username);

            updateJsonFiles();
            LoadAllProfessors(); //reload
        }

        private void mnuAddCourse_Click(object sender, EventArgs e)
        {
            var ipCourseID = Interaction.InputBox("Enter courseID", "", "");
            if (!ipCourseID.Equals(""))
            {
                var ipName = Interaction.InputBox("Enter course name", "", "");
                if (!ipName.Equals(""))
                {
                    var ipType = Interaction.InputBox("Enter course type", "", "");
                    if (!ipType.Equals(""))
                    {
                        allCourses.addNewCourse(ipCourseID, ipName, allProfessorInfo[lst_Professor.SelectedIndex].name, ipType);
                        allUsers.addNewCourse(ipCourseID, allProfessorInfo[lst_Professor.SelectedIndex].username);
                        allAssignments.addNewCourse(ipCourseID);
                    }
                }
            }

            updateJsonFiles();
            lst_Professor_SelectedIndexChanged(this, null);
        }

        private void mnuDeleteCourse_Click(object sender, EventArgs e)
        {
            allCourses.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            allUsers.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            allAssignments.deleteACourse(allCourseInfo[lst_Course.SelectedIndex].id);
            updateJsonFiles();
            lst_Professor_SelectedIndexChanged(this, null);
        }

        private void mnuAddStudent_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to add an existing student to this course?",
              "",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    List<string> arrAllStudent = new List<string>();
                    string displayName = "";
                    foreach (var pair in allUsers.allUsers)
                    {
                        if (pair.Value.userType.Equals("Student"))
                        {
                            arrAllStudent.Add(pair.Value.id);
                            displayName += "\n" + pair.Value.name + " (id: " + pair.Value.id + ")";
                        }
                    }
                    
                    var ipStudentID = Interaction.InputBox("List of exising students: \n" + displayName + "\n\nPlease choose a student ID to add", "", "");

                    if (!ipStudentID.Equals(""))
                    {
                        var arr = new ArrayList();
                        var rand = new Random();
                        foreach (var totalAssignment in allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).totalAssignment)
                        {
                            int randomID = rand.Next(100, 10000);
                            arr.Add(randomID.ToString());
                        }
                        allUsers.addAnExistingUsertoACourse(allCourseInfo[lst_Course.SelectedIndex].id, ipStudentID, arr);
                        allCourses.updateACourse(allCourseInfo[lst_Course.SelectedIndex].id, ipStudentID, arr);
                        allAssignments.updateAssignmentOfACourse(allCourseInfo[lst_Course.SelectedIndex].id, ipStudentID, arr);
                        updateJsonFiles();
                        lst_Course_SelectedIndexChanged(this, null);
                    }
                    break;

                case DialogResult.No:
                    addNewStudent();
                    break;

                case DialogResult.Cancel:
                    // "Cancel" processing
                    break;
            }       
        }

        private void addNewStudent()
        {
            var arr = new ArrayList();
            var rand = new Random();
            foreach (var totalAssignment in allAssignments.getInfoOfAAssignment(allCourseInfo[lst_Course.SelectedIndex].id).totalAssignment)
            {
                int randomID = rand.Next(100, 10000);
                arr.Add(randomID.ToString());
            }

            var ipUsername = Interaction.InputBox("Enter username", "", "");
            if (!ipUsername.Equals(""))
            {
                var ipPass = Interaction.InputBox("Enter password", "", "");
                if (!ipPass.Equals(""))
                {
                    var ipName = Interaction.InputBox("Enter name", "", "");
                    if (!ipName.Equals(""))
                    {
                        var ipMajor = Interaction.InputBox("Enter major", "", "");
                        if (!ipMajor.Equals(""))
                        {
                            var generateID = rand.Next(1000, 10000).ToString();
                            allUsers.addNewUser(generateID, ipName, ipUsername, ipPass, ipMajor, "Student", allCourseInfo[lst_Course.SelectedIndex].id, arr);
                            allCourses.updateACourse(allCourseInfo[lst_Course.SelectedIndex].id, generateID, arr);
                            allAssignments.updateAssignmentOfACourse(allCourseInfo[lst_Course.SelectedIndex].id, generateID, arr);
                        }
                    }
                }
            }

            updateJsonFiles();
            lst_Course_SelectedIndexChanged(this, null);
        }

        private void mnuDeleteStudent_Click(object sender, EventArgs e)
        {
            allUsers.deleteAUser(allStudentInfo[lst_Student.SelectedIndex].username);
            allCourses.deleteAUserInACourse(allCourseInfo[lst_Course.SelectedIndex].id, allStudentInfo[lst_Student.SelectedIndex].id);
            allAssignments.deleteAUser(allCourseInfo[lst_Course.SelectedIndex].id, allStudentInfo[lst_Student.SelectedIndex].id);
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

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadAllProfessors();
            //LoadAllStudents();
        }

        private void LoadAllProfessors()
        {
            allProfessorInfo.Clear();
            lst_Professor.Items.Clear();
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
            if (lst_Professor.SelectedIndex != -1)
            {
                loadUserInfo(allProfessorInfo[lst_Professor.SelectedIndex].username, "Professor");
            }
            
        }

        private void loadUserInfo(string username, string userType)
        {
            UserInfo user = allUsers.getInfoOfAUser(username, false);
            thisUserInfo = user;

            if (userType.Equals("Professor"))
            {
                lblName.Text = user.name;
                if (user.allEnrolledCourses.Count > 1)
                {
                    lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
                }
                else
                {
                    lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " course";
                }
                lblProfessorID.Text = "ID: " + user.id;
                lblTitle.Text = user.major;
            }
            
            //get all enrolled courses
            loadEnrolledCourses(user, userType);
        }

        private void loadEnrolledCourses(UserInfo user, string userType)
        {
            allCourseInfo.Clear();
            lst_Course.Items.Clear();
            foreach (var pair in user.allEnrolledCourses)
            {
                var courseID = pair.Key;
                CourseInfo course = allCourses.getInfoOfACourse(courseID);
                allCourseInfo.Add(course);
                var courseName = course.name;

                if (userType.Equals("Professor"))
                {
                    lst_Course.Items.Add(courseName);
                }
                
            }
        }

        private void lst_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Course.SelectedIndex != -1)
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
                    //lst_ManageStudent.Items.Add(pair.Value.name);
                }
            }
        }

        private void lst_ManageStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadUserInfo(allManageStudentInfo[lst_ManageStudent.SelectedIndex].username, "Student");
        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void lst_Student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
