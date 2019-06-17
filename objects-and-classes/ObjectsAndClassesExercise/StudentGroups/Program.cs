using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class Student
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string TownName { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var towns = new List<Town>();
            var groups = new List<Group>();

            GetTownsAndStudents(inputLine, towns);

            DistributeStudentsIntoGroups(towns, groups);

            PrintGroups(towns, groups);
        }   

        public static void PrintGroups(List<Town> towns, List<Group> groups)
        {
            var townsDistinct = towns.Distinct().ToArray();
            Console.WriteLine($"Created {groups.Count} groups in {townsDistinct.Length} towns:");
            foreach (var cell in groups.OrderBy(x => x.Town.TownName))
            {
                Console.Write($"{cell.Town.TownName} => ");

                for (int i = 0; i < cell.Students.Count; i++)
                {
                    Console.Write($"{cell.Students[i].StudentEmail}");
                    if (i < cell.Students.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns, List<Group> groups)
        {
            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate)
                    .ThenBy(s => s.StudentName)
                    .ThenBy(s => s.StudentEmail);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }

        static List<Town> GetTownsAndStudents(string inputLine, List<Town> towns)
        {
            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    towns.Add(GetTown(inputLine));
                }
                else
                {
                    towns[towns.Count - 1].Students.Add(GetStudent(inputLine));
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }

        static Town GetTown(string inputLine)
        {
            var town = new Town();
            var townAndSeats = inputLine.Split(new string[] { " => " }, StringSplitOptions.None).ToList();

            town.TownName = townAndSeats[0];
            town.SeatsCount = int.Parse(townAndSeats[1].Split(' ').First());
            town.Students = new List<Student>();

            return town;
        }

        static Student GetStudent(string inputLine)
        {
            var student = new Student();
            var studentInfo = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            student.StudentName = string.Concat(studentInfo[0].Where(c => !char.IsWhiteSpace(c)));
            student.StudentEmail = string.Concat(studentInfo[1].Where(c => !char.IsWhiteSpace(c)));

            var dateString = string.Concat(studentInfo[2].Where(c => !char.IsWhiteSpace(c)));
            student.RegistrationDate = GetDate(dateString);

            return student;
        }

        static DateTime GetDate(string dateString)
        {
            var dateList = dateString.Split('-');
            for (int i = 1; i <= 12; i++)
            {
                var dtf = new DateTimeFormatInfo();
                var monthStr = dtf.GetMonthName(i).ToString();
                if (monthStr.Contains(dateList[1]))
                {
                    dateList[1] = i.ToString();
                    break;
                }
            }

            var newDate = DateTime.ParseExact(string.Join("-", dateList), "d-M-yyyy", CultureInfo.InvariantCulture);
            return newDate;
        }
    }
}
