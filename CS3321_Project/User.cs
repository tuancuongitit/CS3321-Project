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

        public UserInfo getInfoOfAUser(string username)
        {
            return allUsers[username];
        }

    }

    public class UserInfo
    {
        [JsonProperty("id")]
        public int id { get; set; }
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

        public static explicit operator UserInfo(CourseInfo v)
        {
            throw new NotImplementedException();
        }
    }

    public class enrolledCourseInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }
    }
}
