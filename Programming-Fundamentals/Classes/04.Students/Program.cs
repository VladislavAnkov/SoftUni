using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();


            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, secondName, grade);

                students.Add(student);

            }

            students = students.OrderByDescending(g => g.Grade).ToList();

            foreach (var currentStudent in students)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }

    class Student
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{firstName} {secondName}: {grade:f2}";
        }

    }
}
