using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeCheckerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCaseSimplePass()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome(@"abcba"));
        }
        [TestMethod]
        public void TestCaseSimpleFail()
        {
            Assert.AreEqual(false, PalindromeCheckerApp.Program.IsPalindrome(@"abcde"));
        }
        [TestMethod]
        public void TestCaseComplexPass1()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome(@"Mr owl ate my metal worm"));
        }
        [TestMethod]
        public void TestCaseComplexPass2()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome(@"Never Odd Or Even"));
        }
        [TestMethod]
        public void TestCaseComplexFail1()
        {
            Assert.AreEqual(false, PalindromeCheckerApp.Program.IsPalindrome(@"Never Even Or Odd"));
        }
        [TestMethod]
        public void TestEdgeCaseNull()
        {
            Assert.AreEqual(false, PalindromeCheckerApp.Program.IsPalindrome(null));
        }
        [TestMethod]
        public void TestEdgeCaseEmptyString()
        {
            Assert.AreEqual(false, PalindromeCheckerApp.Program.IsPalindrome(string.Empty));
        }
        [TestMethod]
        public void TestBlackBoxCasePunctuationPass()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome(@"Nev#er Odd Or E#ven"));
        }
        [TestMethod]
        public void TestBlackBoxCaseLongStringPass()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome(@"Nev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd Or E#ven"));
        }
        [TestMethod]
        public void TestBlackBoxCaseLongStringControlCharactersPass()
        {
            Assert.AreEqual(true, PalindromeCheckerApp.Program.IsPalindrome("Nev#er O\r\ndd Or E#venNev#er Odd Or E#venNev#er Odd Or E#venNev#er Odd \n\rOr E#ven"));
        }
    }
}
