using System;

namespace SenderModule
{
    public static class RowPrinter
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
    }
}
