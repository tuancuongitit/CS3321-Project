using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    public abstract class User
    {
        private string userID, password, name, typeOfUser;

        public User(string userID, string password, string name, string type) //constructor 
        {
            this.userID = userID;
            this.password = password;
            this.name = name;
            this.typeOfUser = type;
        }

        public string getName()
        {
            return this.name;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getID()
        {
            return this.userID;
        }

        public string getTypeOfUser()
        {
            return this.typeOfUser;
        }

        public abstract ArrayList getAllCourseAsAList();
        
    }
}
