using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').ToArray();
            var inputText = Console.ReadLine();

            var m = int.Parse(inputNums[0].ToString());
            var n = int.Parse(inputNums[1].ToString());

            var regex = new Regex(@"(\|<)[A-Za-z0-9]+");

            var matches = regex.Matches(inputText);

            var cameras = matches
                    .Cast<Match>()
                    .Select(a => a.Value)
                    .ToArray();

            var photos = new List<string>();

            for (int i = 0; i < cameras.Length; i++)
            {
                var currentCamera = cameras[i].Skip(m + 2).Take(n).ToArray();
                photos.Add(new string(currentCamera));
            }

            Console.WriteLine(string.Join(", ", photos));
        }
    }
}
