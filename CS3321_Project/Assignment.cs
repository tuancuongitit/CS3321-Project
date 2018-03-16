using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    class Assignment
    {

        private string assignmentName;
        private double assignmentGrade;

        public Assignment(string name)
        {
            this.setAssignment(name, -1);
        }

        public Assignment (string name, double grade)
        {
            this.setAssignment(name, grade);
        }

        public void setAssignment(string name, double grade)
        {
            this.assignmentName = name;
            this.assignmentGrade = grade;
        }

        public string getName()
        {
            return this.assignmentName;
        }

        public double getGrade()
        {
            return this.assignmentGrade;
        }

        public void setGrade(double grade)
        {
            this.assignmentGrade = grade;
        }

        public override string ToString()
        {
            return "Assignment: " + getName() + " - Grade: " + getGrade();
        }
    }

    
}
