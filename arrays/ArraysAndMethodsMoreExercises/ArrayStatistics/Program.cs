using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            PrintArr(arr);
        }

        static void PrintArr(double[] array)
        {
            Console.WriteLine($"Min = {MinElement(array)}");
            Console.WriteLine($"Max = {MaxElement(array)}");
            Console.WriteLine($"Sum = {SumOfElements(array)}");
            Console.WriteLine($"Average = {AverageOfElements(array)}");
        }

        static double MinElement(double[] array)
        {
            return array.Min();
        }

        static double MaxElement(double[] array)
        {
            return array.Max();
        }

        static double SumOfElements(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static double AverageOfElements(double[] array)
        {
            return SumOfElements(array) / array.Length;
        }
    }
}
