using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class Professor : User
    {
        private Dictionary<string, ProfessorCourse> dictCourses = new Dictionary<string, ProfessorCourse>();

        public Professor(string userID, string password, string name, string type) : base(userID, password, name, type)
        {
        }

        public void addCourse(ProfessorCourse course)
        {
            dictCourses.Add(course.getCourseName(), course);
        }

        public Dictionary<string, ProfessorCourse> getAllCourses()
        {
            Dictionary<string, ProfessorCourse> returnDict = new Dictionary<string, ProfessorCourse>();
            foreach (string name in dictCourses.Keys)
            {
                returnDict.Add(name, dictCourses[name]);
            }

            return returnDict;
        }

        public ProfessorCourse getACourse(string course)
        {
            if (dictCourses.ContainsKey(course))
            {
                return dictCourses[course];
            }
            return null;
        }

        public bool checkCourseExist(string course)
        {
            if (dictCourses.ContainsKey(course))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override ArrayList getAllCourseAsAList()
        {
            ArrayList returnArray = new ArrayList();
            foreach (ProfessorCourse item in dictCourses.Values)
            {
                returnArray.Add(item);
            }
            return returnArray;
        }

        public ArrayList getAllStudentsOfACourse(string course, string IDorNAME)
        {
            ArrayList returnArr = new ArrayList();
            if (IDorNAME.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                foreach (string userid in dictCourses[course].getAllStudents().Keys)
                {
                    returnArr.Add(userid);
                }
                return returnArr;
            } else
            {
                foreach (string name in dictCourses[course].getAllStudents().Values)
                {
                    returnArr.Add(name);
                }
                return returnArr;
            }
        }
    }
}
