using System;
using System.Linq;

namespace SenderModule
{
    public static class ColumnFilter
    {
        public static void PrintCsvColumn(string[] lines)
        {
           
            Console.WriteLine("Enter Column Number (0 or 1)");
            var columnNumber = Convert.ToInt32(Console.ReadLine());

            foreach (var columns in lines.Where(str => !string.IsNullOrEmpty(str)).Select(str => str.Split(','))
                .Where(str => str.Length > 1 && !string.IsNullOrEmpty(str[1]))
                .ToArray())
            {
                PrintSpecificColumn(columns[columnNumber]);
                
            }
           
        }

        private static void PrintSpecificColumn(string columns)
        {
            //Console.WriteLine(columns); //It Prints each comment on separate line

            //Below prints each word of comment on separate line.
            var words = columns.Split(' ');
            Array.ForEach(words, Console.WriteLine);
        }
    }
}
