using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace CS3321_Project
{
    public class Assignment
    {
        [JsonProperty("courses")]
        public Dictionary<string, aCourseInfo> allAssignments { get; set; }

        public aCourseInfo getInfoOfAAssignment(string course_id)
        {
            return allAssignments[course_id];
        }
    }

    public class aCourseInfo
    {
        [JsonProperty("course_id")]
        public string course_id { get; set; }
        [JsonProperty("total_assignment")]
        public ArrayList totalAssignment { get; set; }
        [JsonProperty("students")]
        public Dictionary<string, aStudentInfo> aStudentInfo { get; set; }
    }

    public class aStudentInfo
    {
        [JsonProperty("assignmentID")]
        public Dictionary<string, AssignmentInfo> allAssignmentsOfAStudent { get; set; }
    }

    public class AssignmentInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("grade")]
        public long grade { get; set; }
    }
    
}
