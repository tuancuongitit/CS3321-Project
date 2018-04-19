using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class Course
    {
        private string courseName;
        Dictionary<string, Assignment> dictAssignment = new Dictionary<string, Assignment>();

        public Course(string courseName)
        {
            this.courseName = courseName;
        }

        public string getCourseName()
        {
            return this.courseName;
        }

        public void addAssignment(Assignment assign)
        {

        }

        public Dictionary<string, Assignment> getAllAssignment()
        {
            Dictionary<string, Assignment> returnDict = new Dictionary<string, Assignment>();
            foreach (string name in dictAssignment.Keys)
            {
                returnDict.Add(name, dictAssignment[name]);
            }

            return returnDict;
        }

        public ArrayList getAllAssignmentsAsAList()
        {
            ArrayList returnArray = new ArrayList();
            foreach (Assignment item in dictAssignment.Values)
            {
                returnArray.Add(item);
            }
            return returnArray;
        }

        public Assignment getOneAssignment(string name)
        {
            if (dictAssignment.ContainsKey(name))
            {
                return dictAssignment[name];
            }
            return null;
        }

    }
}
