using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignments
{
    class tables
    {

        public static void Main(string[] args)
        {
            int p = 1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            while (p <= 200)
            {
                Console.WriteLine($"{n}*{p}={n * p}");
                p++;
            }
        }
    }
}

