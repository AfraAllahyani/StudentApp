using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { };
            int[] Grades = { };
            string result;
            for (int a = 0; a <= Names.Length; a++)
            {
                // Take student name and increment array by 1 
                Console.Write("Type student name: ");
                Array.Resize(ref Names, Names.Length + 1);
                Names[Names.GetUpperBound(0)] = Console.ReadLine();
                //Take student Grade and increment array by 1
                Console.Write("Type student Grade: ");
                Array.Resize(ref Grades, Grades.Length + 1);
                Grades[Grades.GetUpperBound(0)] = Convert.ToInt32(Console.ReadLine());
                //after taking student info , aske if finish or not
                Console.WriteLine("Do you finish entering students ? ( yes / no )");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
            for (int a = 0; a < Names.Length; a++)
            {
                if (Grades[a] >= 60) { result = "Passed"; }
                else { result = "Failed"; }
                Console.Write("| Student name is: {0} | Her Grade is: {1} | she is:  {2}", Names[a], Grades[a], result + "\n");
            }

        }
    }
}
