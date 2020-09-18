using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class InputReaderWriter
    {
        public class ConsoleInputReader
        {
            public static List<string> ReadInput()
            {
                var rawData = new List<string>();
                string comment;
                while ((comment = Convert.ToString(Console.ReadLine())) != "EOF")
                {
                    rawData.Add(comment);
                }
                return rawData;
            }
        }

        public class outputWriter
        {
            public static void csvGenerator(Dictionary<string, int> processedData, bool noInputDetected)
            {
                if (noInputDetected)
                {
                    var outputFile = new StreamWriter("output.csv");
                    outputFile.WriteLine("No Data");
                    outputFile.Close();
                }
                else
                {
                    var outputFile = new StreamWriter("output.csv");
                    foreach (KeyValuePair<string, int> wordCount in processedData)
                    {
                        outputFile.WriteLine(wordCount.Key + "," + wordCount.Value);
                        Console.WriteLine(wordCount.Key + " " + wordCount.Value);
                    }
                    Console.ReadLine();
                    outputFile.Close();
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sit Back and Relax and let me do my thing .......");
            var inputData = ConsoleInputReader.ReadInput();
            if (inputData.Count == 0)
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();
                outputWriter.csvGenerator(dic, true);
            }
            else
            {
                inputMining mineInput = new inputMining();
                var wordCount = mineInput.ProcessInput(inputData);
                //wordCount = removeStopWords.removeStopWorsFromProcessedData(wordCount);
                outputWriter.csvGenerator(wordCount, false);

            }
        }
    }
}
