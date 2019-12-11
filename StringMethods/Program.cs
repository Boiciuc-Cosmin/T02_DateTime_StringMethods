using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Cosmin-Ionel";
            string lastName = "Boiciuc";
            string fullName = string.Concat(lastName, " ", firstName);
            Console.WriteLine("Concat ex: {0}", fullName);

            string empty = string.Empty;
            if (string.IsNullOrEmpty(empty))
            {
                Console.WriteLine("Stringul este null sau gol");
            }
            else
            {
                Console.WriteLine("Stringul contine ceva");
            }

            string s1 = "Ana are Mere";
            string s2 = "ana are mere";

            if (string.Compare(s1, s2, true) == 0)
            {
                Console.WriteLine("Stringurile sunt egale");
            }
            else
            {
                Console.WriteLine("Stringurile nu sunt egale");
            }
            Console.WriteLine(s1.Replace("Mere", "pere") + " " + s2.Remove(5, 4));
            Console.WriteLine(s2.ToUpper() + " " + s1.ToLower());

            string spati = "   Spatiul este mare   ";
            Console.WriteLine(spati.Trim());
            Console.WriteLine(spati.TrimStart());
            Console.WriteLine(spati.TrimEnd());

            string substring = "Toata lumea are mere";
            Console.WriteLine(substring.Substring(6));
            Console.WriteLine(substring.Substring(0, 11));
            string search = Console.ReadLine();
            if (substring.Contains(search))
            {
                Console.WriteLine("Textul contine stringul cautat");
            }
            else
            {
                Console.WriteLine("Textul nu contine stringul cautat");
            }
            string starts = Console.ReadLine();
            if (substring.StartsWith(starts))
            {
                Console.WriteLine("Textul incepe cu {0}", starts);
            }
            else
            {
                Console.WriteLine("Textul nu incepe cu {0}", starts);
            }

        }
    }
}