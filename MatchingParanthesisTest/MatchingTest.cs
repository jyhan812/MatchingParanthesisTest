using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchingParenthesis;

namespace MatchingParanthesisTest
{
    [TestClass]
    public class MatchingTest
    {
        [TestMethod]
        public void MatchTest()
        {
            var testing = new Matching();

            string input = "(45*)()3+()()";

            Assert.AreEqual(true, testing.hasMatches(input));
           
        }
    }
}
