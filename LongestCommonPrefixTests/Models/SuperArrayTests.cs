using LongestCommonPrefixConsoleApp.Models;
using Xunit;

namespace LongestCommonPrefixTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void GetLongestCommonPrefix_Should_Return_Prefix()
        {
            var strs = new [] {"flower", "flow", "flight"};
            const string ExpectedResult = "fl";

            string result = SuperArray.GetLongestCommonPrefix(strs);

            Assert.Equal(result, ExpectedResult);
        }

        [Fact]
        public void GetLongestCommonPrefix_Should_Return_Empty_String()
        {
            var strs = new [] {"carlos", "isela"};
            
            string result = SuperArray.GetLongestCommonPrefix(strs);

            Assert.Empty(result);
        }
    }
}