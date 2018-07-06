﻿using System;

namespace myBenchmark.Runner
{
    public static class FizzBuzzLogic
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        public static string Execute(int number)
        {
            string result;
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = fizz + buzz;
            }
            else if (number % 3 == 0)
            {
                result = fizz;
            }
            else if (number % 5 == 0)
            {
                result = buzz;
            }
            else
            {
                result = $"{number}";
            }
            return result;
        }
    }
}
