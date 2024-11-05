using System;
using System.Text.RegularExpressions;
namespace lab8
{
    internal class Program
    {
        static void Main()
        {
            string text = "<p>I'm going to come back to my company 47.</p>";
            Console.WriteLine(text);
            string pattern = @"<\s*(html|form|h1)\s*>";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(text))
            {
                Console.WriteLine("\nText is a HTML code.");
            }
            else Console.WriteLine("\nText is not a HTML code.");
        }
    }
}