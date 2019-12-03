using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    public class Follower
    {
        public Follower(string username, int likes, int comments)
        {
            this.Username = username;
            this.Likes = likes;
            this.Comments = comments;
        }

        public string Username { get; set; }

        public int Likes { get; set; }

        public int Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var followers = new List<Follower>();

            string command = Console.ReadLine();
            while (command != "Log out")
            {
                string[] commandParts = command.Split(": ");

                string action = commandParts[0];
                if (action == "New follower")
                {
                    string username = commandParts[1];

                    if (!followers.Any(f => f.Username == username))
                    {
                        var follower = new Follower(username, 0, 0);
                        followers.Add(follower);
                    }
                }
                else if (action == "Like")
                {
                    string username = commandParts[1];
                    int likesCount = int.Parse(commandParts[2]);

                    if (!followers.Any(f => f.Username == username))
                    {
                        var follower = new Follower(username, likesCount, 0);
                        followers.Add(follower);
                    }
                    else
                    {
                        followers.Find(u => u.Username == username).Likes += likesCount;
                    }
                }
                else if (action == "Comment")
                {
                    string username = commandParts[1];

                    if (!followers.Any(f => f.Username == username))
                    {
                        var follower = new Follower(username, 0, 1);
                        followers.Add(follower);
                    }
                    else
                    {
                        followers.Find(u => u.Username == username).Comments++;
                    }
                }
                else if (action == "Blocked")
                {
                    string username = commandParts[1];

                    if (!followers.Any(f => f.Username == username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        var followerToRemove = followers.Find(f => f.Username == username);
                        followers.Remove(followerToRemove);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers.OrderByDescending(l => l.Likes).ThenBy(u => u.Username))
            {
                Console.WriteLine($"{follower.Username}: {follower.Likes + follower.Comments}");
            }
        }
    }
}
