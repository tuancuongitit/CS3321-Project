using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace CS3321_Project
{
    public class courseInfo
    {
        private int id;
        private List<int> assignmentIDs;
    }

    public class User 
    {
        private int id;
        private string name, major, userType, username, password;
        private List<courseInfo> courses;

        public User(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["users"];
            id = (int)jUser["id"];
            name = (string)jUser["name"];
            major = (string)jUser["major"];
            userType = (string)jUser["usertype"];
            username = (string)jUser["username"];
            password = (string)jUser["password"];
        }

        public string getName()
        {
            return this.name;
        }

        public string getPassword()
        {
            return this.password;
        }

        public int getID()
        {
            return this.id;
        }

        public string getTypeOfUser()
        {
            return this.userType;
        }

        //public abstract ArrayList getAllCourseAsAList();
        
    }
}
