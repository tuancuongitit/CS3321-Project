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
    public partial class frm_Main : Form
    {
        public static Database data = new Database();
        public frm_Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (data.checkUserLogin(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Login Successfully");
                frm_UserDetail frm = new frm_UserDetail();
                frm.data = data;
                frm.userID = txtUser.Text;
                this.Hide();
                frm.ShowDialog();
                
            } else
            {
                MessageBox.Show("Login Failed");
            } 
        }
    }
}
