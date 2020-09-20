using System;

namespace SenderModule
{
    public static class RowColumnPrinter
    {
        public static void PrintAllRowsOfCsvFile(string[] lines)
        {
            //var lineCount = 0;
            foreach (var line in lines)
            {
                //  lineCount++;

                var columns = line.Split(',');
                foreach (var column in columns)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }

            //return lineCount;
        }

        public static void PrintAllColumnsOfcsvFile(string[] lines)
        {
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
        }
    }
}
