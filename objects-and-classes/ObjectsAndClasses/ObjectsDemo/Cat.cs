using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsDemo
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class TalkingCat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"My name is {Name}. Meow!");
        }
    }

    class AnotherCat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Legs()
        {
            return 4;
        }
    }
}
