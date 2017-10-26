using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork5;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Group2 gr2 = new Group2();
        Group3 gr3 = new Group3();

        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(11, "11")]
        [DataRow(12345, "12345")]
        public void TestIntToStr(int value, string exp)
        {
            string act = gr2.IntToStr(value);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIntToStrExeption()
        {
            string act = gr2.IntToStr(-1);
        }

        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(1.1, "1.1")]
        [DataRow(12.345, "12.345")]
        public void TestRealToStr(double value, string exp)
        {
            string act = gr2.RealToStr(value);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRealToStrExeption()
        {
            string act = gr2.RealToStr(-1.0);
        }

        [DataTestMethod]
        [DataRow("0", 0)]
        [DataRow("11", 11)]
        [DataRow("12345", 12345)]
        public void TestStrToInt(string value, int exp)
        {
            int act = gr2.StrToInt(value);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStrToIntExeption()
        {
            int act = gr2.StrToInt(null);
        }

        [DataTestMethod]
        [DataRow("0.0", 0.0)]
        [DataRow("1.1", 1.1)]
        [DataRow("12.345", 12.345)]
        public void TestStrToReal(string value, double exp)
        {
            double act = gr2.StrToReal(value);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStrToRealExeption()
        {
            int act = gr2.StrToInt(null);
        }

        [DataTestMethod]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("aa aaa", 2)]
        [DataRow("aa,aaa", 2)]
        [DataRow("aaa, aaaa", 3)]
        [DataRow("aaaa,aaa,aa,a,aaaaa", 1)]
        [DataRow("aaaa aaa aa a aaaaa", 1)]
        [DataRow("aaaa,    aaa, aa, ,,   aaa, aaaaa", 2)]
        public void TestShortestWord(string str, int exp)
        {
            int act = gr3.ShortestWord(str);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestShortestWordException()
        {
            int res = gr3.ShortestWord(null);
        }

        [DataTestMethod]
        [DataRow(3, new string[] { "aaaa" }, new string[] { "aaaa" })]
        [DataRow(4, new string[] { "bbbb" }, new string[] { "b$$$" })]
        [DataRow(5, new string[] { "cccc", "ddddd" }, new string[] { "cccc", "dd$$$" })]
        [DataRow(3, new string[] { "aaaa", "bbb", "ccccc", "abc" }, new string[] { "aaaa", "$$$", "ccccc", "$$$" })]
        public void TestLettersToDollars(int length, string[] array, string[] exp)
        {
            gr3.LettersToDollars(array, length);
            CollectionAssert.AreEqual(exp, array);
        }

        [DataTestMethod]
        [DataRow(3, new string[] { }, new string[] { })]
        [ExpectedException(typeof(EmptyArrayException))]
        public void TestLettersToDollarsEmptyException(int length, string[] array, string[] exp)
        {
            gr3.LettersToDollars(array, length);
        }

        [DataTestMethod]
        [DataRow(2, new string[] { "aaaa", "bbb", "ccccc", "abc" }, new string[] { "aaaa", "$$$", "ccccc", "$$$" })]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestLettersToDollarsOutException(int length, string[] array, string[] exp)
        {
            gr3.LettersToDollars(array, length);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("aaaa", "aaaa")]
        [DataRow("cccc,ddddd", "cccc, ddddd")]
        [DataRow("aaaa, bbb,ccccc,abc", "aaaa, bbb, ccccc, abc")]
        public void TestAddingSpaces(string str, string exp)
        {
            string res = gr3.AddingSpaces(str);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingSpacesException()
        {
            string res = gr3.AddingSpaces(null);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("aaaa", "a")]
        [DataRow("ccccddddd", "cd")]
        [DataRow("aaaabbbcccccabc", "abc")]
        public void TestleaveOneOfRepeated(string str, string exp)
        {
            string res = gr3.LeaveOneOfRepeated(str);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestleaveOneOfRepeatedException()
        {
            string res = gr3.LeaveOneOfRepeated(null);
        }

        [DataTestMethod]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("aa aaa", 2)]
        [DataRow("aa,aaa", 2)]
        [DataRow("aaa, aaaa", 2)]
        [DataRow("aaaa,aaa,aa,a,aaaaa", 5)]
        [DataRow("aaaa aaa aa a aaaaa", 5)]
        [DataRow("aaaa,    aaa, aa, ,,   aaa, aaaaa", 5)]
        public void TestNumberOfWords(string str, int exp)
        {
            int act = gr3.NumberOfWords(str);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNumberOfWordsException()
        {
            int res = gr3.NumberOfWords(null);
        }

        [DataTestMethod]
        [DataRow(1, 2, "abcd", "ad")]
        [DataRow(2, 3, "abcdefg", "abfg")]
        public void TestRemove(int pos, int num, string str, string exp)
        {
            string res = gr3.Remove(str, pos, num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemoveNullException()
        {
            string res = gr3.Remove(null, 0, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyArrayException))]
        public void TestRemoveEmptyException()
        {
            string res = gr3.Remove("", 0, 1);
        }

        [DataTestMethod]
        [DataRow(-1, 2, "abcd", "ad")]
        [DataRow(2, 3, "abcdefg", "abfg")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveEmptyException(int pos, int num, string str, string exp)
        {
            string res = gr3.Remove(str, pos, num);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("a", "a")]
        [DataRow("ab", "ba")]       
        [DataRow("abczx", "xzcba")]
        public void TestReverse(string str, string exp)
        {
            string act = gr3.Reverse(str);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestReverseNullException()
        {
            string act = gr3.Reverse(null);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("a", "")]
        [DataRow("aa aaa", "aa")]
        [DataRow("aaaa aaa aa a aaaaa", "aaaa aaa aa a")]
        public void TestRemoveLastWord(string str, string exp)
        {
            string act = gr3.RemoveLastWord(str);
            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemoveLastWordNullException()
        {
            string act = gr3.RemoveLastWord(null);
        }
    }
}
