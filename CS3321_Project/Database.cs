using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project {
    public class Database {
        private static Dictionary<string, User> dictAccount = new Dictionary<string, User>();

        public Database()
        {
            loadDatabase();
        }

        public void loadDatabase()
        {
            //For English Class, Professor Jason, total Student = 5, total Assignments = 3
            Professor pro1 = new Professor("2111", "999", "Jason", "Statham");
            ProfessorCourse eng = new ProfessorCourse("English");
            ProfessorCourse chem = new ProfessorCourse("Chemistry");
            pro1.addCourse(eng);
            pro1.addCourse(chem);

            //Pro2
            Professor pro2 = new Professor("2112", "999", "Henry", "Ford");
            ProfessorCourse math = new ProfessorCourse("Math");
            ProfessorCourse biology = new ProfessorCourse("Biology");
            pro2.addCourse(biology);
            pro2.addCourse(math);

            int totalStudent = 5;
            Student[] allStudents = new Student[totalStudent];

            Student s1 = new Student("1111", "999", "Justin", "Bieber");
            Student s2 = new Student("1112", "999", "Charlie", "Puth");
            Student s3 = new Student("1113", "999", "Selena", "Gomez");
            Student s4 = new Student("1114", "999", "Taylor", "Swift");
            Student s5 = new Student("1115", "999", "Bruno", "Mars");

            allStudents[0] = s1;
            allStudents[1] = s2;
            allStudents[2] = s3;
            allStudents[3] = s4;
            allStudents[4] = s5;

            //English Class
            for (int i = 0; i < allStudents.Length; i++)
            {
                pro1.getACourse(eng.getCourseName()).addStudent(allStudents[i].getName(), allStudents[i].getID());
                allStudents[i].addCourse(new StudentCourse("English", "Jason Statham"));
                allStudents[i].getACourse("English").addAssignment(new Assignment("Homework1", 0));
                allStudents[i].getACourse("English").addAssignment(new Assignment("Homework2", 0));
                allStudents[i].getACourse("English").addAssignment(new Assignment("Homework3", 0));
                allStudents[i].getACourse("English").addAssignment(new Assignment("Midterm Review", 0));
                allStudents[i].getACourse("English").addAssignment(new Assignment("Midterm Exam", 0));

                dictAccount.Add(allStudents[i].getID(), allStudents[i]);
            }

            //Chem
            for (int i = 0; i < allStudents.Length - 3; i++)
            {
                pro1.getACourse(chem.getCourseName()).addStudent(allStudents[i].getName(), allStudents[i].getID());
                allStudents[i].addCourse(new StudentCourse("Chemistry", "Jason Statham"));
                allStudents[i].getACourse("Chemistry").addAssignment(new Assignment("Lab Practice", 0));
                allStudents[i].getACourse("Chemistry").addAssignment(new Assignment("Exam 1", 0));
            }

            pro1.getACourse(eng.getCourseName()).addAssignment(new Assignment("Homework1"));
            pro1.getACourse(eng.getCourseName()).addAssignment(new Assignment("Homework2"));
            pro1.getACourse(eng.getCourseName()).addAssignment(new Assignment("Homework3"));
            pro1.getACourse(eng.getCourseName()).addAssignment(new Assignment("Midterm Review"));
            pro1.getACourse(eng.getCourseName()).addAssignment(new Assignment("Midterm Exam"));

            pro1.getACourse(chem.getCourseName()).addAssignment(new Assignment("Lab Practice"));
            pro1.getACourse(chem.getCourseName()).addAssignment(new Assignment("Exam 1"));

            dictAccount.Add(pro1.getID(), pro1);

            //Professor 2
            for (int i = 2; i < allStudents.Length; i++)
            {
                pro2.getACourse(math.getCourseName()).addStudent(allStudents[i].getName(), allStudents[i].getID());
                allStudents[i].addCourse(new StudentCourse("Math", "Henry Ford"));
                allStudents[i].getACourse("Math").addAssignment(new Assignment("Presentation", 0));
                allStudents[i].getACourse("Math").addAssignment(new Assignment("Take home quiz", 0));
                allStudents[i].getACourse("Math").addAssignment(new Assignment("Essay", 0));
            }

            //Biology

            for (int i = 1; i < allStudents.Length - 1; i++)
            {
                pro2.getACourse(biology.getCourseName()).addStudent(allStudents[i].getName(), allStudents[i].getID());
                allStudents[i].addCourse(new StudentCourse("Biology", "Henry Ford"));
                allStudents[i].getACourse("Biology").addAssignment(new Assignment("Quiz 1", 0));
                allStudents[i].getACourse("Biology").addAssignment(new Assignment("Project", 0));
            }

            pro2.getACourse(math.getCourseName()).addAssignment(new Assignment("Presentation"));
            pro2.getACourse(math.getCourseName()).addAssignment(new Assignment("Take home quiz"));
            pro2.getACourse(math.getCourseName()).addAssignment(new Assignment("Essay"));

            pro2.getACourse(biology.getCourseName()).addAssignment(new Assignment("Quiz 1"));
            pro2.getACourse(biology.getCourseName()).addAssignment(new Assignment("Project"));

            dictAccount.Add(pro2.getID(), pro2);

            Console.WriteLine("Database was loaded successfully!");
        }

        public bool checkUserLogin(string userID, string password)
        {
            if (dictAccount.ContainsKey(userID))
            {
                return dictAccount[userID].getPassword().Equals(password, StringComparison.OrdinalIgnoreCase);
            } else
            {
                return false;
            }
        }

        public User getUserInformation(string userID)
        {
            if (dictAccount.ContainsKey(userID))
            {
                return dictAccount[userID];
            } else
            {
                return null;
            }
        }

    }
}
