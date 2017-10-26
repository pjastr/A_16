using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź zdanie i naciśnij Enter.");
            string zdanie = Console.ReadLine();
            string wynik = "";
            string[] slowa = zdanie.Split(new[] { " " }, StringSplitOptions.None);
            for (int i = slowa.Length - 1; i >= 0; i--)
            {
                wynik += slowa[i] + " ";
            }
            Console.WriteLine("Odwrócna kolejność:");
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}
