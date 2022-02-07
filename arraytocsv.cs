using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignments
{
    class arraytocsv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "I";
            files[0, 1] = "love";
            files[0, 2] = "u";
            files[0, 3] = "varshini";
            files[0, 4] = "muskan";

            files[1, 0] = " 1";
            files[1, 1] = "7";
            files[1, 2] = "17";
            files[1, 3] = "florida";
            files[1, 4] = "ka16";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");
        }
    }
}

