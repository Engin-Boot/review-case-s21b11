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

                    foreach (var line in lines)
                    {
                        var columns = line.Split(',');

                        foreach (var column in columns)
                        {

                            Console.Write(column + " ");
                        }

                        Console.WriteLine();
                    }

                    break;

                case "col":
                    //Read columns
                    ColumnFilter.PrintCsvColumn(lines);
                    break;

                default:

                    Console.WriteLine("Invalid user input");
                    break;
            }
        }
    }
}
