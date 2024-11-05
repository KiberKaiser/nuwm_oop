using System;
using System.Text.RegularExpressions;
namespace lab8
{
    internal class Program
    {
        static void Main()
        {
            string text = "https://orcid.org/0000-0005-9257-4532";
            Console.WriteLine(text);
            string pattern = @"\b0000-000[1-9]-\d{4}-\d{3}[\dX]\b ";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(text))
            {
                Console.WriteLine("\nIt's ORCID ID.");
            }
            else Console.WriteLine("\nIt isn't ORCID ID.");
        }
    }
}