using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Group
    {
        public string Name { get; set; }
        public List<DateTime> Dates = new List<DateTime>();
        public List<string> Comments = new List<string>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }).ToArray();
            var students = new List<Group>();
            var comments = new List<string>();
            var dates = new List<DateTime>();

            while (input[0] != "end")
            {
                if (input.Length > 1)
                {
                    dates = GetDate(input);
                }

                if (students.Any(x => x.Name == input[0]))
                {
                    students.Single(x => x.Name == input[0]).Dates.AddRange(dates);
                }
                else
                {
                    students.Add(NameAndDate(input, dates));
                }

                input = Console.ReadLine().Split(new char[] { ' ', ',' }).ToArray();
            }

            var commentsInput = Console.ReadLine().Split('-').ToArray();

            while (commentsInput[0] != "end of comments")
            {
                GetComments(commentsInput, comments);
                CommentsToGroup(students, commentsInput, comments);

                comments.Clear();

                commentsInput = Console.ReadLine().Split('-').ToArray();
            }

            PrintGroupMembers(students);
        }

        public static List<DateTime> GetDate(string[] input)
        {
            var currentDates = new List<DateTime>();
            for (int i = 1; i < input.Length; i++)
            {
                currentDates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }

            return currentDates;
        }

        public static Group NameAndDate(string[] input, List<DateTime> dates)
        {
            var student = new Group();

            student.Name = input[0];
            student.Dates = dates;

            return student;
        }

        public static List<string> GetComments(string[] input, List<string> comments)
        {
            for (int i = 1; i < input.Length; i++)
            {
                comments.Add(input[i]);
            }

            return comments;
        }

        public static List<Group> CommentsToGroup(List<Group> students, string[] input, List<string> comments)
        {
            int indexa = students.FindIndex(r => r.Name == input[0]);

            if (indexa < 0)
            {
                return students;
            }

            for (int i = 0; i < comments.Count; i++)
            {
                students[indexa].Comments.Add(comments[i]);
            }

            return students;
        }

        public static void PrintGroupMembers(List<Group> students)
        {
            foreach (var name in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(name.Name);
                Console.WriteLine("Comments:");
                foreach (var comments in name.Comments)
                {
                    Console.WriteLine($"- {comments}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var dates in name.Dates.OrderBy(d => d.Date))
                {
                    Console.WriteLine($"-- {dates:dd/MM/yyyy}");
                }
            }
        }
    }
}
