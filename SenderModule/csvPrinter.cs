using System;

namespace SenderModule
{
    public static class CsvPrinter
    {
        public static void PrintTheCsvFile(string[] lines)
        {
            //Console.WriteLine("Enter 'row' to print CSV file Row-Wise and 'col' to print CSV file Column-Wise");
            var readerInput = Console.ReadLine();

            switch (readerInput)
            {
                case "row":
                    //var lineCount = 0;
                    RowColumnPrinter.PrintAllRowsOfCsvFile(lines);
                    break;

                case "col":
                    //Read columns
                    RowColumnPrinter.PrintAllColumnsOfcsvFile(lines);
                    break;

                default:
                    Console.WriteLine("Invalid user input");
                    break;
            }
        }
    }
}
