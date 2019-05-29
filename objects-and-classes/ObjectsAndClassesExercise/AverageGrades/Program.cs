using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Student[] students = GetStudents(n);
            students = SortStudents(students);

            PrintStudentsNameAvgGrade(students);
        }

        private static void PrintStudentsNameAvgGrade(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        private static Student[] SortStudents(Student[] students)
        {
            return students
                .Where(ag => ag.AverageGrade >= 5.00)
                .OrderBy(n => n.Name)
                .ThenByDescending(ag => ag.AverageGrade)
                .ToArray();
        }

        static Student[] GetStudents(int studentsCount)
        {
            var students = new Student[studentsCount];
            for (int i = 0; i < studentsCount; i++)
            {
                var studentInfoList = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                students[i] = new Student
                {
                    Name = studentInfoList.First().ToString(),
                    Grades = studentInfoList.Skip(1).Select(double.Parse).ToList()
                };
            }

            return students;
        }
    }
}
