using System;
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

            string strTest = "((45+)^*&$)(";

            bool result = testing.hasMatches(strTest);
        }
    }
}
