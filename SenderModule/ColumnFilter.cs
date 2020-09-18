using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Services;

namespace Sender
{
    class ColumnFilter
    {
        public bool printCSVColumn(string[] lines)
        {
            bool isPrinted = false;

            Console.WriteLine("Enter column number (0 or 1)");
            int columnNumber = Convert.ToInt32(Console.ReadLine());

            foreach (var columns in lines.Where(str => !string.IsNullOrEmpty(str)).Select(str => str.Split(','))
                .Where(str => str.Length > 1 && !string.IsNullOrEmpty(str[1]))
                .ToArray())
            {
                PrintSpecificColumn(columns[columnNumber]);
                isPrinted = true;
            }
            return isPrinted;
        }

        private bool PrintSpecificColumn(string columns)
        {
            foreach (var column in columns)
            {
                Console.Write(column);
            }
            Console.WriteLine();

            return true;
        }
    }
}
