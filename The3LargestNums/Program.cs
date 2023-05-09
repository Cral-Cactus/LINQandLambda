using System;
using System.Linq;

namespace The3LargestNums
{
    internal class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] largest = nums.OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ", largest));
        }
    }
}