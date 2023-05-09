using System;
using System.Linq;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            double[] left = numbers.Take(k)
                .Reverse()
                .ToArray();
            double[] right = numbers.Reverse()
                .Take(k)
                .ToArray();

            double[] row1 = left.Concat(right)
                .ToArray();
            double[] row2 = numbers.Skip(k)
                .Take(2 * k)
                .ToArray();

            double[] sum = row1.Select((x, index) => x + row2[index])
                .ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}