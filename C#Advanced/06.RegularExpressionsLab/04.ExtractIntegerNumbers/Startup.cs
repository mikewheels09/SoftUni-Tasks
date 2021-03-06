﻿using System;
using System.Text.RegularExpressions;

namespace _04.ExtractIntegerNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var matches = Regex.Matches(text, "[0-9]+");

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
