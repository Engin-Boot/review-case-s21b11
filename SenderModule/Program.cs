using System;

namespace SenderModule
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string path = @"E:\Philips\BootCamp\Review-case-s21b11-master\sample-review\Review-report.csv";
            //Necessary to put @ symbol at start of path, 
            //else it gives "System.ArgumentException: 'Illegal characters in path.'"

            var checkPath = PathExistence.CheckFileExistOrNot(path);
            if (checkPath)
            {
                var lines = System.IO.File.ReadAllLines(path);

                CsvPrinter.PrintTheCsvFile(lines);
            }
            else
            {
                Console.WriteLine("ALERT..! Check file available or not..!");
            }

        }
    }
}
