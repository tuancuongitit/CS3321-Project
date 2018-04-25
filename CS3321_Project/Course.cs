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

        public void addNewCourse(string course_id, string name, string professor, string type)
        {
            CourseInfo aNewCourse = new CourseInfo(course_id, name, professor, type);
            allCourses.Add(course_id, aNewCourse);
        }

        public void deleteACourse(string course_id)
        {
            allCourses.Remove(course_id);
        }

        public void updateACourse(string course_ID, string student_ID, ArrayList assignmentIDList)
        {
            enrolledStudentInfo enroll = new enrolledStudentInfo(student_ID, assignmentIDList);
            allCourses[course_ID].allEnrolledStudent.Add(student_ID, enroll);
        }

        public void deleteAUserInACourse(string course_id, string user_id)
        {
            allCourses[course_id].allEnrolledStudent.Remove(user_id);
        }

        public void addNewAssignment(string course_id, string student_id, string assignment_id) 
        {
            allCourses[course_id].allEnrolledStudent[student_id].assignmentIDList.Add(assignment_id);
        }

        public void deleteAssignment(string course_id, string student_id, string assignment_id)
        {
            allCourses[course_id].allEnrolledStudent[student_id].assignmentIDList.Remove(assignment_id);
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
        public Dictionary<string, enrolledStudentInfo> allEnrolledStudent { get; set; }

        public CourseInfo(string id, string name, string professor, string type)
        {
            this.id = id;
            this.name = name;
            this.professor = professor;
            this.type = type;
            this.allEnrolledStudent = new Dictionary<string, enrolledStudentInfo>();
        }
    }

    public class enrolledStudentInfo
    {
        [JsonProperty("studentID")]
        public string id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }

        public enrolledStudentInfo(string student_id, ArrayList assignmentIDList)
        {
            this.id = student_id;
            this.assignmentIDList = assignmentIDList;
        }
    }
}
