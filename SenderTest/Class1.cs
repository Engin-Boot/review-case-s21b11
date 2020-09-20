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

        [Theory]
        [InlineData(@"E:\Philips\Review-case-s21b11-master\sample-review\Review-report.csv")]
        [InlineData(@"E:\Philips\Review-case-s21b11-master\Review-report.csv")]
        [InlineData(@"E:\Philips\Boot_camp\Review-case-s21b11-master\Review-report.csv")]
        public void TestingForTheNonExistenceOfCsvFile(string csvPath)
        {
            //const string csvPath = @"E:\Philips\Review-case-s21b11-master\sample-review\Review-report.csv";
            PathExistence.CheckFileExistOrNot(csvPath);
            Assert.False(PathExistence.CheckFileExistOrNot(csvPath));
        }


        /*[Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ThrowExceptionIfColumnNumberIsOutOfRange(int expectedColumnNumber)
        {
            const string csvPath = @"C:\Users\320103928\review-case-s21b11\sample-review\review-report.csv";
            var checkPath = PathExistence.CheckFileExistOrNot(csvPath);

            if (checkPath)
            {
                var lines = System.IO.File.ReadAllLines(csvPath);
                Assert.Throws<System.IndexOutOfRangeException>(() => ColumnFilter.PrintCsvColumn(lines, expectedColumnNumber));
            }
            else {
                Assert.True(false);
            }
        }

        
        [Fact]
        public void CheckingSizeOfCsvFile()
        {
            //Arrange
             const int Expected_File_Size = 3007;

            var actualFileSize = Program.file_size(); 
            Assert.Equal(Expected_File_Size, actualFileSize);

        }*/
    }
}
