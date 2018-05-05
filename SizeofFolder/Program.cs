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
            string path = "c:\\your\\dir\\path\\is\\here";
            CalculateSize directory = new CalculateSize(path);

            directory.Size();

            Console.ReadKey();
        }
    }
}