using System;
using System.Collections.Generic;
using System.IO;

namespace ReceiverModule
{
    public class InputReaderWriter
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

        public class OutputWriter
        {
            public static void CsvGenerator(Dictionary<string, int> processedData, bool noInputDetected)
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
                    foreach (var wordCount in processedData)
                    {
                        outputFile.WriteLine(wordCount.Key + "," + wordCount.Value);
                        Console.WriteLine(wordCount.Key + " " + wordCount.Value);
                    }
                    Console.ReadLine();
                    outputFile.Close();
                }
            }

        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Sit Back and Relax and let me do my thing .......");
            var inputData = ConsoleInputReader.ReadInput();
            if (inputData.Count == 0)
            {
                var dic = new Dictionary<string, int>();
                OutputWriter.CsvGenerator(dic, true);
            }
            else
            {
                InputMining mineInput = new InputMining();
                var wordCount = mineInput.ProcessInput(inputData);
                //wordCount = removeStopWords.removeStopWorsFromProcessedData(wordCount);
                OutputWriter.CsvGenerator(wordCount, false);

            }
        }
    }
}
