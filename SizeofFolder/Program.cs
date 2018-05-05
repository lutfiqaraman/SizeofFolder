using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeofFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "c:\\your\\path\\is\\here\\";
                string[] files = Directory.GetFiles(path);
                double size = files.Select(file => new FileInfo(file).Length).Sum();

                size = Math.Round(size / 1000000, 1);

                if (size >= 300)
                    Console.WriteLine("The size of directory is {0} MB. \n Directory is overloaded", size);
                else
                    Console.WriteLine("The size of directory is {0} MB. \n Directory is not overloaded", size);
            }

            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found: " + dirEx.Message);
            }

            Console.ReadKey();
        }
    }
}