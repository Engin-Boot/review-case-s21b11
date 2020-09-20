using System;

namespace SenderModule
{
    public static class CsvPrinter
    {
        public static void PrintTheCsvFile(string[] lines)
        {
            Console.WriteLine("Enter 'row' to print CSV file Row-Wise and 'col' to print CSV file Column-Wise");
            var readerInput = Console.ReadLine();

            switch (readerInput)
            {
                case "row":
                    //var lineCount = 0;
                    RowPrinter.PrintAllRowsOfCsvFile(lines);
                    break;

                case "col":
                    //Read columns
                    try
                    {
                        Console.WriteLine("Enter Column Number (0 or 1)");
                        var columnNumber = Convert.ToInt32(Console.ReadLine());
                        ColumnFilter.PrintCsvColumn(lines, columnNumber);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid user input");
                    break;
            }
        }
    }
}
