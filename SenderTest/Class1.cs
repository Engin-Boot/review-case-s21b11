using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sender;
using Xunit;
using System.IO;
using System.Threading.Tasks;

namespace SenderTest
{
    public class Class1
    {
        [Fact]
        public void TestingForTheExitanceOfCSVFile() { 
            string CSVPath = @"C:\Users\320103928\review-case-s21b11\sample-review\review-report.csv";
            PathExistance Exist = new PathExistance();
            Assert.True(Exist.CheckFileExistorNot(CSVPath));
        }

        [Fact]
        public void TestingForTheNonExitanceOfCSVFile()
        {
            string CSVPath = @"C:\Users\320103928\review-case-s21b11\review-report.csv";
            PathExistance Exist = new PathExistance();
            Assert.False(Exist.CheckFileExistorNot(CSVPath));
        }

        //[Fact]
        //public void 
    }
}
