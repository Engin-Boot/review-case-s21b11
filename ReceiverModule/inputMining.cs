using System.Collections.Generic;

namespace ReceiverModule
{
    public class InputMining
    {
        public List<string> ParseInput(List<string> rawInputData)
        {
            var separator = new[] {' ', '.', ','};
            var parsedCommentList = new List<string>();

            foreach (var comment in rawInputData)
            {
                var words = comment.Split(separator);
                foreach (var word in words)
                {
                    parsedCommentList.Add(word);
                }
            }

            return parsedCommentList;
        }

        public List<string> RemoveStopWordsFromParsedComments(List<string> parsedComments)
        {
         return RemoveStopWords.RemoveStopWordsHelper(parsedComments);

        }

        public Dictionary<string, int> WordFrequencyGenerator(List<string> comments)
        {
            var parsedComments = ParseInput(comments);
            var commentsFreeFromStopWords = RemoveStopWordsFromParsedComments(parsedComments);

            var wordCount = new Dictionary<string, int>();
            foreach (var word in commentsFreeFromStopWords)
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

            return wordCount;
        }
    }
}

