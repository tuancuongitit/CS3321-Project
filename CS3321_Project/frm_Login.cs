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

        public frm_Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_DB_in_jSonFile();
        }

        private void load_DB_in_jSonFile()
        {
            var json = File.ReadAllText("assignmentDB.json");
            Assignment all = JsonConvert.DeserializeObject<Assignment>(json);
            all.allAssignments.Add("1248", new Info(1248, "Test", 90));
            foreach (KeyValuePair<string, Info> item in all.allAssignments)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.name);
            }

            string output = JsonConvert.SerializeObject(all);
            Console.WriteLine(output);
              


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            load_DB_in_jSonFile();
        }
    }
}
