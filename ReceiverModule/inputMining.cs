using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class inputMining
    {
        public Dictionary<string, int> ProcessInput(List<string> rawInputData)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < rawInputData.Count; i++)
            {
                string comment = rawInputData[i];
                string word = "";
                for (int j = 0; j < rawInputData[i].Length; j++)
                {
                    if (rawInputData[i][j] == ' ')
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount.Add(word, 1);
                        }
                        word = "";
                    }
                    else
                    {
                        word += rawInputData[i][j];
                    }
                }
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }
            return wordCount;
        }
    }
}
