using System;
using System.Text.RegularExpressions;

namespace rubbish
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1-205-ASDAS330-2a342";
            string result = Regex.Replace(input, @"[^\d]", "");
            Console.WriteLine(result); // >> 12053302342
        }
    }
}