using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ReceiverModule;


namespace ReceiverModule.Test
{
    public class ReceiverModuleUnitTest
    {
        [Fact]

        public void WhenBothDataAndTimeArePassedStoreThemInRawCommentsList()
        {
            var CommentWithDate = new List<string>{"10/10/2020 5:24 PM, Good job fixing the error"};

        }
    }
}
