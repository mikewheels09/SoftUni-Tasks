﻿using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();

                    string contents = input.Substring
                                     (startIndex, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }

        }
    }
}
