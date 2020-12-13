using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AoC2020
{
    class Task0
    {
        /*
         * The input file 0.txt contains a list of numbers. Let's find the sum of the numbers.
         */
        public static void Part1()
        {
            var lines = File.ReadAllLines(@"..\..\..\input\0.txt");
            int sum = 0;
            foreach (string line in lines)
            {
                sum += int.Parse(line);
            }
            Console.WriteLine(sum);
        }

        /*
         * And now let's find the largest number.
         */
        public static void Part2()
        {
            var lines = File.ReadAllLines(@"..\..\..\input\0.txt");
            int max = int.MinValue;
            foreach (string line in lines)
            {
                int number = int.Parse(line);
                if (number > max)
                    max = number;
            }
            Console.WriteLine(max);
        }
    }
}
