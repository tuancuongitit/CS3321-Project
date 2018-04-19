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
            
            
        }

        private void lstCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
