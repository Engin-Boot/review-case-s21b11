using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data;

namespace Sender
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\320103928\Case_Study1\reviewreport.csv";
            //Necessary to put @ symbol at start of path, 
            //else it gives "System.ArgumentException: 'Illegal characters in path.'"
            PathExistance exist = new PathExistance();
            bool checkPath = exist.checkFileExistorNot(path);

            if (checkPath)
            {
                string[] lines = System.IO.File.ReadAllLines(path);

                csvPrinter printCSV = new csvPrinter();
                printCSV.printTheCSVFile(lines);
            }
            else
            {
                Console.WriteLine("ALERT..! Check file available or not..!");
            }

        }
    }
}
