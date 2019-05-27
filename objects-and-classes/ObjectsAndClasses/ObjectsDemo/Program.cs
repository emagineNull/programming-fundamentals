using System;
using System.Collections.Generic;

namespace ObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new { Name = "Ivan", Age = 5, Color = "Black" };
            var secondCat = new { Name = "Gosho", Age = 10, Color = "Mixed" };

            Console.WriteLine(cat.Name);
            Console.WriteLine(secondCat.Age);

            var randomObject = new
            {
                RandomProperty = true,
                OtherRandomProperty = 5
            };

            var car = new
            {
                Name = "LaFerrari",
                Age = 10,
                Owner = new
                {
                    FirstName = "Alek",
                    LastName = "Rifai"
                }
            };

            Console.WriteLine(car.Name + " " + car.Owner.FirstName + " " + car.Owner.LastName);

            var date = new DateTime(2019, 5, 27);

            Console.WriteLine(date.DayOfWeek);

            Console.WriteLine();

            var catWithClass = new Cat
            {
                Name = "Ivan",
                Age = 5
            };

            var cats = new List<Cat>();

            cats.Add(catWithClass);

            for (int i = 0; i < 100; i++)
            {
                cats.Add(new Cat
                {
                    Name = "Cat " + i,
                    Age = i,
                });
            }

            foreach (var kitty in cats)
            {
                Console.WriteLine(kitty.Name);
            }

            var helloKitty = new TalkingCat
            {
                Name = "Gosho",
                Age = 12
            };

            helloKitty.SayHello();

            var differentCat = new AnotherCat
            {
                Name = "Goshka",
                Age = 15
            };

            Console.WriteLine("Name of cat: " + differentCat.Name);
            Console.WriteLine("Age of cat: " + differentCat.Age);
            Console.WriteLine("Number of legs: " + differentCat.Legs());
        }
    }
}
