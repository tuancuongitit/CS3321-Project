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

        public void updateAssignmentOfACourse(string course_ID, string student_id, ArrayList assignmentIDList)
        {
            aStudentInfo newStudent = new aStudentInfo();

            int i = 0;
            foreach (var assignments in assignmentIDList)
            {
                Console.WriteLine(assignments);
                newStudent.allAssignmentsOfAStudent.Add(assignments.ToString(), new AssignmentInfo(assignments.ToString(), allAssignments[course_ID].totalAssignment[i].ToString(), 0));
                i++;
            }
            
            allAssignments[course_ID].aStudentInfo.Add(student_id, newStudent);
        }

        public void deleteAUser(string course_id, string user_id)
        {
            allAssignments[course_id].aStudentInfo.Remove(user_id);
        }

        public void addNewCourse(string course_id)
        {
            aCourseInfo aNewCourseInfo = new aCourseInfo(course_id);
            allAssignments.Add(course_id, aNewCourseInfo);
        }

        public void deleteACourse(string course_id)
        {
            allAssignments.Remove(course_id);
        }

        public void addNewAssignment(string course_id, string student_id, string assignment_id, string assignment_name)
        {
            if (!allAssignments[course_id].totalAssignment.Contains(assignment_name)) {
                allAssignments[course_id].totalAssignment.Add(assignment_name);
            }
            
            AssignmentInfo newAssignment = new AssignmentInfo(assignment_id, assignment_name, 0);
            allAssignments[course_id].aStudentInfo[student_id].allAssignmentsOfAStudent.Add(assignment_id, newAssignment);
        }

        public void deleteAssignment(string course_id, string assignmentName, string assignment_id, string student_id)
        {
            allAssignments[course_id].totalAssignment.Remove(assignmentName);
            allAssignments[course_id].aStudentInfo[student_id].allAssignmentsOfAStudent.Remove(assignment_id);
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

        public aCourseInfo(string course_id)
        {
            this.course_id = course_id;
            this.totalAssignment = new ArrayList();
            this.aStudentInfo = new Dictionary<string, CS3321_Project.aStudentInfo>();
        }

    }

    public class aStudentInfo
    {
        [JsonProperty("assignmentID")]
        public Dictionary<string, AssignmentInfo> allAssignmentsOfAStudent { get; set; }

        public aStudentInfo() {
            this.allAssignmentsOfAStudent = new Dictionary<string, AssignmentInfo>();
        }

        public aStudentInfo(AssignmentInfo newAssignment)
        {
            this.allAssignmentsOfAStudent = new Dictionary<string, AssignmentInfo>();
            this.allAssignmentsOfAStudent.Add(newAssignment.id, newAssignment);
        }
    }

    public class AssignmentInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("grade")]
        public long grade { get; set; }

        public AssignmentInfo(string id, string name, long grade)
        {
            this.id = id;
            this.name = name;
            this.grade = grade;
        }
    }
    
}
