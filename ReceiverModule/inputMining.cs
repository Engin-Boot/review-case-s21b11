using System.Collections.Generic;

namespace ReceiverModule
{
    public class InputMining
    {
        public Dictionary<string, int> ProcessInput(List<string> rawInputData)
        {
            var wordCount = new Dictionary<string, int>();
            var separator = new char[] { ' ', '.', ',' };

            foreach (var comment in rawInputData)
            {
                //var comment = rawInputData[i];
                var words = comment.Split(separator);
                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount.Add(word, 1);
                    }
                }
            }
            return wordCount;
        }
    }
}
