using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150914_Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            if (int.Parse(number) % 5 == 0 && int.Parse(number) % 7 == 0)
            {
                Console.WriteLine("Divisble by 5 and 7 with no remainder.");
            }
            else
            {
                Console.WriteLine("Not divisble by 5 and 7 with no remainder.");
            }

        }
    }
}
