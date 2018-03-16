using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    class StudentCourse : Course
    {
        private string professorName;

        public StudentCourse(string courseName, string professor) : base(courseName)
        {
            this.professorName = professor;
        }

        public string getProfessorName()
        {
            return this.professorName;
        }
    }
}
