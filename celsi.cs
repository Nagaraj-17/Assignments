using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignments
{
    class celsi
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Celcius");
            int celcius = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("kelvin = {0}", celcius + 273+"k");
            Console.WriteLine("fahrenhiet = {0}", celcius * 18 / 10 + 32+"f");
        }
    }
}



