using System;
using System.Collections.Generic;


namespace student
{
    class Program
    {
        public static int sameGrade (List<int> Grades, int grade)
        {
            int numberOfStudents = 0;
            foreach (var item in Grades)
            {
                if (grade == item)
                numberOfStudents += 1;

            }
            return numberOfStudents;
        }

        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            List<int> Grades = new List<int>();
            string studentName = "";
            int studentGrade ;

            for (int a = 0; a <= Names.Count; a++)
            {
                Console.WriteLine("student name: ");
                studentName  = Console.ReadLine();
                Names.Add(studentName);
               
                Console.WriteLine("student Grade: ");
                studentGrade = Convert.ToInt32(Console.ReadLine());
                Grades.Add(studentGrade);
                
                Console.WriteLine("Add Another student ? ( yes / no )");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    continue;
                }
                else
                {
                    break; 
                }     
            }
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine("Student Name : " + Names[i] + " sudent grade: " + Grades[i]);
            }
            Console.WriteLine("Enter the grade to search: ");
            int gradefromuser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Student with grade: {0} is: {1} ",gradefromuser, sameGrade(Grades, gradefromuser));
        }
    }
}

