using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                double grade = double.Parse(input[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }

                students[studentName].Add(grade);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (double grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
