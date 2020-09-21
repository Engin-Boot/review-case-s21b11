using System;
using System.Collections.Generic;
using System.IO;

namespace ReceiverModule
{ 
    public interface IInputReader
    {
        public List<string> ReadInput();
    }

   public interface  IOutputGenerator
    {
        public void CsvGenerator(Dictionary<string, int> processedData, bool noInputDetected);
    }

    public class ConsoleInputReader : IInputReader
    {
        public List<string> ReadInput()
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

    public class OutputWriter : IOutputGenerator
    {
        public void CsvGenerator(Dictionary<string, int> processedData, bool noInputDetected)
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

    public abstract class MainMethod
    {
        public static void Main()
        {
            Console.WriteLine("Sit Back and Relax and let me do my thing .......");
            var getInput = new ConsoleInputReader();
            var writeOutput = new OutputWriter();

            var inputData = getInput.ReadInput();
            if (inputData.Count == 0)
            {
                var dic = new Dictionary<string, int>();
                writeOutput.CsvGenerator(dic, true);
            }
            else
            {
                InputMining mineInput = new InputMining();
                var wordCount = mineInput.WordFrequencyGenerator(inputData);
                writeOutput.CsvGenerator(wordCount, false);

            }
        }
    }
}
