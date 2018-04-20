using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CS3321_Project
{
    public class Course
    {
        [JsonProperty("courses")]
        public Dictionary<string, CourseInfo> allCourses { get; set; }

        public CourseInfo getInfoOfACourse(string course_id)
        {
            return allCourses[course_id];
        }
    }

    public class CourseInfo
    {
        [JsonProperty("course_id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("professor")]
        public string professor { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("students")]
        public Dictionary<string, enrolledCourseInfo> allEnrolledStudent { get; set; }
    }

    public class enrolledStudentInfo
    {
        [JsonProperty("studentID")]
        public int id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }
    }
}
