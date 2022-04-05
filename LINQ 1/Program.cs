using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestForSquares(new List<int>() { 1, 2, 4 }, new List<int>() { 1, 2, 16 }));

        }

        private static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers
                   .Select(num => num * num)
                   .SequenceEqual(squares);
        }
    }
}
