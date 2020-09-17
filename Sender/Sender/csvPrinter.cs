using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class csvPrinter
    {
        public void printTheCSVFile(string[] lines)
        {

            Console.WriteLine("Enter 'row' to print CSV file rowwise and 'col' to print CSV file columnwise");
            string readerInput = Console.ReadLine();

            if (readerInput == "row")
            {
                foreach (string line in lines)
                {

                    string[] columns = line.Split(',');

                    foreach (string column in columns)
                    {

                        Console.Write(column + " ");
                    }

                    Console.WriteLine();
                }
            }
            else if (readerInput == "col")
            {
                //Read columns
                ColumnFilter colF = new ColumnFilter();
                colF.printCSVColumn(lines);
            }
            else
            {
                Console.WriteLine("Invalid user input");
            }
        }
    }
}
