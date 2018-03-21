using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    class Student : User
    {
        public Student(string userID, string password, string name, string type) : base(userID, password, name, type) {}
        private Dictionary<string, StudentCourse> dictCourses = new Dictionary<string, StudentCourse>();

        public void addCourse(StudentCourse course)
        {
            dictCourses.Add(course.getCourseName(), course);
        }

        public Dictionary<string, StudentCourse> getAllCourses()
        {
            Dictionary<string, StudentCourse> returnDict = new Dictionary<string, StudentCourse>();
            foreach (string name in dictCourses.Keys)
            {
                returnDict.Add(name, dictCourses[name]);
            }

            return returnDict;
        }

        public StudentCourse getACourse(string course)
        {
            if (dictCourses.ContainsKey(course))
            {
                return dictCourses[course];
            }
            return null;
        }

        public override ArrayList getAllCourseAsAList()
        {
            ArrayList returnArray = new ArrayList();
            foreach (StudentCourse item in dictCourses.Values) {
                returnArray.Add(item);
            }
            return returnArray;
        }
    }
}
