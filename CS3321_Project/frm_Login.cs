using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Web;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CS3321_Project
{
    public partial class frm_Main : Form
    {

        private User allUsers;
        private Course allCourses;
        private Assignment allAssignments;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            load_DB_in_jSonFile();
        }

        private void load_DB_in_jSonFile()
        {
            var json = File.ReadAllText("usersDB.json");
            allUsers = JsonConvert.DeserializeObject<User>(json);
            json = File.ReadAllText("coursesDB.json");
            allCourses = JsonConvert.DeserializeObject<Course>(json);
            json = File.ReadAllText("assignmentDB.json");
            allAssignments = JsonConvert.DeserializeObject<Assignment>(json);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (allUsers.userAuth(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show(@"Login Successfully");
                frm_UserDetail detail = new frm_UserDetail(txtUser.Text, allUsers, allCourses, allAssignments);
                this.Hide();
                detail.ShowDialog();
            } else
            {
                MessageBox.Show(@"Please try again!");
            }
        }
    }
}
