using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class ProfessorCourse : Course
    {
        private Dictionary<string, string> dictStudent = new Dictionary<string, string>();

        public ProfessorCourse(string courseName) : base(courseName)
        {
        }

        public void addStudent(string userID, string name)
        {
            dictStudent.Add(userID, name);
        }

        public Dictionary<string, string> getAllStudents()
        {
            Dictionary<string, string> returnDict = new Dictionary<string, string>();
            foreach (string userID in dictStudent.Keys)
            {
                returnDict.Add(userID, dictStudent[userID]);
            }

            return returnDict;
        }

         
    }
}
