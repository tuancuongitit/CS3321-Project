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
    public partial class frm_Admin : Form
    {
        private Assignment allAssignments;
        private Course allCourses;
        private User allUsers;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private UserInfo thisUserInfo;

        public frm_Admin()
        {
            InitializeComponent();
        }

        public frm_Admin(string username, User allUsers, Course allCourses, Assignment allAssignments)
        {
            InitializeComponent();
            this.username = username;
            this.allUsers = allUsers;
            this.allCourses = allCourses;
            this.allAssignments = allAssignments;
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadAllProfessors();
        }

        private void LoadAllProfessors()
        {

        }
    }
}
