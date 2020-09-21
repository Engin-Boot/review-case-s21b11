﻿using System;

namespace SenderModule
{
    public static class Program
    {
        public static void Main()
        {
            const string path = @"C:\Users\320106688\Documents\review-case-s21b11\sample-review\review-report.csv";
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
                Console.WriteLine("ALERT..! Check the file path or check file available or not..!");
            }
            Console.WriteLine("EOF");
            Console.ReadLine();
        }
    }
}
