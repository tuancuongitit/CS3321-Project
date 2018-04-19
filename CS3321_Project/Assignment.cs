using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CS3321_Project
{
    public class Assignment
    {
        [JsonProperty("assignments")]
        public Dictionary<string, Info> allAssignments { get; set; }
    }

    public class Info
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("grade")]
        public float grade { get; set; }
        
        public Info(int newid, string newname, float newgrade)
        {
            this.id = newid;
            this.name = newname;
            this.grade = newgrade;
        }
    }



    
}
