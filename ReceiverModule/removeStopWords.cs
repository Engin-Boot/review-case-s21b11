﻿using System.Collections.Generic;

namespace ReceiverModule
{
    public class RemoveStopWords
    {
        private readonly HashSet<string> _stopWords = new HashSet<string>() {"i",
            "me", "my", "myself", "we", "our", "ours", "ourselves", "you",
            "your", "yours", "yourself", "yourselves", "he", "him", "his",
            "himself", "she", "her", "hers", "herself", "it", "its", "itself",
            "they", "them", "their", "theirs", "themselves", "what", "which",
            "who", "whom", "this", "that", "these", "those", "am", "is", "are",
            "was", "were", "be", "been", "being", "have", "has", "had", "having",
            "do", "does", "did", "doing", "a", "an", "the", "and", "but", "if",
            "or", "because", "as", "until", "while", "of", "at", "by", "for",
            "with", "about", "against", "between", "into", "through", "during",
            "before", "after", "above", "below", "to", "from", "up", "down",
            "in", "out", "on", "off", "over", "under", "again", "further",
            "then", "once", "here", "there", "when", "where", "why", "how",
            "all", "any", "both", "each", "few", "more", "most", "other",
            "some", "such", "no", "nor", "not", "only", "own", "same",
            "so", "than", "too", "very", "s", "t", "can", "will", "just",
            "don", "should", "now"};

        public static List<string> RemoveStopWordsHelper(List<string> processedData) {
            var obj = new RemoveStopWords();
            for (int i = 0; i < processedData.Count; )
            {
                if (obj._stopWords.Contains(processedData[i]))
                {
                    processedData.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return processedData;
        }
    }
}
