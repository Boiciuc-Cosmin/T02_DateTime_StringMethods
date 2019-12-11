using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSamples
{
    class Program
    {
        public enum Gender
        {
            Female = 'F',
            Male = 'M'
        }

        static void Main(string[] args)
        {
            string year, month, day, gender;
            char convgender;
            int maleRetire = 65, femaleRetire = 63, monthsInYear = 12;
            DateTime now = DateTime.Now;

        varsta:
            Console.WriteLine("Introduceti data de nastere");
            Console.Write("Anul: ");
            year = Console.ReadLine();
            Console.Write("Luna: ");
            month = Console.ReadLine();
            Console.Write("Ziua: ");
            day = Console.ReadLine();

            int y = Int32.Parse(year);
            int m = Int32.Parse(month);
            int d = Int32.Parse(day);
            DateTime birthdate = new DateTime(y, m, d);
            if (birthdate > now)
            {
                Console.WriteLine("Data dumneavoastra de nastere este mai mare decat cea curenta va rog sa introduceti o data reala");
                goto varsta;
            }

            TimeSpan difference = now - birthdate;
            double years = Math.Floor(difference.TotalDays / 365.242199);
            double months = Math.Floor((difference.TotalDays % 365) / 30);

            Console.WriteLine("Sunteti nascut la data de " + birthdate.ToString("dd/MM/yyyy"));
            Console.WriteLine($"Varsta dumneavoastra este de {years} ani si {months} luni");

        introdu:
            Console.Write("Care este sexul dumneavoastra [M/F]: ");
            gender = Console.ReadLine();

            if (string.IsNullOrEmpty(gender))
            {
                Console.WriteLine("Nu ati introdus nimic");
                goto introdu;
            }
            else
            {
                convgender = char.Parse(gender.ToUpper());

                if (convgender == (char)Gender.Female)
                {
                    if (years < femaleRetire)
                    {
                        Console.WriteLine($"Varsta de pensionare pentru femei este de {femaleRetire} de ani mai aveti {femaleRetire - years} ani pana la pensionare");
                    }
                    else
                    {
                        Console.WriteLine($"Avand varsta de {years} ani sunteti pensionata");
                    }
                }
                else if (convgender == (char)Gender.Male)
                {
                    if (years < maleRetire)
                    {
                        Console.WriteLine($"Varsta de pensionare pentru barbati este de {maleRetire} de ani mai aveti {maleRetire - years} ani si {monthsInYear - months} luni pana la pensionare");
                    }
                    else
                    {
                        Console.WriteLine($"Avand varsta de {years} ani sunteti pensionat");
                    }
                }
                else
                {
                    Console.WriteLine($"Ati introdus '{gender}' va rog sa introduceti M/F");
                    goto introdu;
                }
            }
        }
    }
}