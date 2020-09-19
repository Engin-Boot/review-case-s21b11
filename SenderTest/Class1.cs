using SenderModule;
using Xunit;

namespace SenderTest
{
    public class Class1
    {
        [Fact]
        public void TestingForTheExistenceOfCsvFile()
        {
            const string csvPath = @"C:\Users\320103928\review-case-s21b11\sample-review\review-report.csv";

            Assert.True(PathExistence.CheckFileExistOrNot(csvPath));
        }

        [Fact]
        public void TestingForTheNonExistenceOfCsvFile()
        {
            const string csvPath = @"E:\Philips\Review-case-s21b11-master\sample-review\Review-report.csv";

            Assert.False(PathExistence.CheckFileExistOrNot(csvPath));
        }

        //[Fact]
        //public void 
    }
}
