using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.FizzBuzz
{
    class FizzBuzz1
    {
        static void Main(string[] args)
        {
            //PrintFizzBuzz1(1, 100);

            Parallel.Invoke(() => PrintFizzBuzz1(1,100));

            //Task task = new Task(() => PrintFizzBuzz1(1,12));

            Console.ReadLine();
        }

        static int Calculate(int x, int y)
        {
            return x + y;
        }

        private static void PrintFizzBuzz1(int start, int end)
        {
            Console.WriteLine(MakeFizzBuzz1(start, end));
        }

        private static string MakeFizzBuzz1(int start, int end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int x = start; x <= end; x++)
            {
                stringBuilder.Append(GetFizzBuzzValue(x));

                stringBuilder.Append("\r\n");
            }
            return stringBuilder.ToString();
        }

        private static string GetFizzBuzzValue(int x)
        {
            string s = "";
            if (x%3 == 0)
            {
                s += "Fizz";
            }
            if (x%5 == 0)
            {
                s += "Buzz";
            }
            if (string.IsNullOrEmpty(s))
            {
                s += x.ToString();
            }
            return s;
        }
    }

    internal class FizzBuzzInt
    {
        private int _value;

        internal void FizzBuzz(int initialValue)
        {
            _value = initialValue;
        }


    }
}
