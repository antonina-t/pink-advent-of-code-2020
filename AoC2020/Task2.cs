using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AoC2020
{
    class Task2
    {
        public static void Part1()
        {
            var lines = File.ReadAllLines(@"../../../input/2.txt");
            int validPassports = 0;

            foreach(string line in lines)
            {
                string[] data = line.Split(" ");
                string[] range = data[0].Split("-");
                int low = int.Parse(range[0]);
                int high = int.Parse(range[1]);
                char letter = data[1].ToCharArray()[0];
                string password = data[2];
                int letterCount = password.Count(c => c == letter);
                if (letterCount >= low && letterCount <= high)
                {
                    validPassports++;
                }
            }

            Console.WriteLine(validPassports);
        }

        public static void Part2()
        {
            var lines = File.ReadAllLines(@"../../../input/0.txt");
        }
    }
}
