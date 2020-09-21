using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ReceiverModule.Test
{
    public class ReceiverModuleUnitTest
    {
        [Fact]

        public void WhenGivenRawCommentAsInputParseItIntoIndividualWords()
        {
            var rawComment = new List<string> {"This is a raw comment"};
            InputMining obj = new InputMining();
            var parsedComment = new List<string>{"This", "is", "a", "raw", "comment"};
            //var difference = new List<string>();
            var difference = parsedComment.Except(obj.ParseInput(rawComment));
            Assert.True(difference.Count() == 0);
        }

        [Fact]
        public void WhenGivenParsedCommentAsInputRemoveTheStopWords()
        {
            var parsedComment = new List<string> {"The", "the", "the", "code", "is", "working"};
            var commentFreeFromStopWords = new List<string> {"code", "working"};
            InputMining obj = new InputMining();
            var difference = commentFreeFromStopWords.Except(obj.RemoveStopWordsFromParsedComments(parsedComment));
            Assert.True(difference.Count() == 0);
        }

        [Fact]

        public void WhenGivenAListOfWordsAsInputGenerateFrequencyOfTheWords()
        {
            var comment = new List<string> {"code looks really neat"};
            var wordFrequency = new Dictionary<string, int> {["code"] = 1, ["looks"] = 1, ["really"] = 1, ["neat"] = 2};
            InputMining obj = new InputMining();
            var programComputedWordFrequency = obj.WordFrequencyGenerator(comment);
            Assert.False(wordFrequency.Equals(programComputedWordFrequency));
        }
    }
}   
