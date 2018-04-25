using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace CS3321_Project
{    

    public class User 
    {
        [JsonProperty("users")]
        public Dictionary<string, UserInfo> allUsers { get; set; }

        public bool userAuth(string username, string password)
        {
            if (allUsers.ContainsKey(username))
            {
                if (allUsers[username].password.Equals(password, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                } else { return false; }
                
            } else {  return false; }
        }

        public void addNewCourse (string course_id, string username)
        {
            enrolledCourseInfo aNewCourseInfo = new enrolledCourseInfo(course_id);
            allUsers[username].allEnrolledCourses.Add(course_id, aNewCourseInfo);
        }

        public void deleteACourse(string course_id)
        {
            foreach (var pair in allUsers)
            {
                if (pair.Value.allEnrolledCourses.ContainsKey(course_id))
                {
                    pair.Value.allEnrolledCourses.Remove(course_id);
                }
            }
        }

        public void addNewUser(string id, string name, string username, string password, string major, string userType, string courseID, ArrayList assignmentID)
        {
            UserInfo newUser = new UserInfo(id, name, major, userType, username, password, courseID, assignmentID);
            allUsers.Add(username, newUser);
        }

        public void deleteAUser(string name) //using name for now
        {
            allUsers.Remove(name);
        }

        public void addNewAssignment(string username, string course_id, string assignment_id)
        {
            allUsers[username].allEnrolledCourses[course_id].assignmentIDList.Add(assignment_id);
        }

        public void deleteAssignment(string username, string course_id, string assignment_id)
        {
            allUsers[username].allEnrolledCourses[course_id].assignmentIDList.Remove(assignment_id);
        }

        public UserInfo getInfoOfAUser(string auth, bool UsingID)
        {
            if (UsingID)
            {
                foreach (var pair in allUsers)
                {
                    if (pair.Value.id.Equals(auth))
                    {
                        return allUsers[pair.Key];
                    }
                }
                return null;
            } else
            {
                return allUsers[auth];
            }
        }

        public string getTypeOfAUser(string username)
        {
            return allUsers[username].userType;
        }

    }

    public class UserInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("major")]
        public string major { get; set; }
        [JsonProperty("userType")]
        public string userType { get; set; }
        [JsonProperty("username")]
        public string username { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("courses")]
        public Dictionary<string, enrolledCourseInfo> allEnrolledCourses { get; set; }

        public UserInfo() { }
        
        public UserInfo(string id, string name, string major, string userType, string username, string password, string courseID, ArrayList assignmentIDList)
        {
            this.id = id;
            this.name = name;
            this.major = major;
            this.userType = userType;
            this.username = username;
            this.password = password;
            this.allEnrolledCourses = new Dictionary<string, enrolledCourseInfo>();

            enrolledCourseInfo newCourse = new enrolledCourseInfo(courseID, assignmentIDList);
            allEnrolledCourses.Add(courseID, newCourse);
        }
    }

    public class enrolledCourseInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }

        public enrolledCourseInfo() { }

        public enrolledCourseInfo(string id) {
            this.id = id;
            this.assignmentIDList = new ArrayList();
        }

        public enrolledCourseInfo(string id, ArrayList assignmentIDList)
        {
            this.id = id;
            this.assignmentIDList = assignmentIDList;
        }
    }
}
