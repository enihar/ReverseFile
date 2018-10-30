using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ReverseFile;

namespace FileReverse.Test
{
    [TestClass]
    public class FileReverseTests
    {
        [TestMethod]
        public void Reverse_Even_Number_Of_Lines()
        {
            var inputLines = new string[] { "hello World", "your text", "will be", "reversed now" };

            var expectedOutput = new string[] { "wello World", "eour text", "will by", "reversed noh" };

            var actualOutput = ReverseFile.FileReverse.ReverseLines(inputLines);

            Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        }

        [TestMethod]
        public void Reverse_Odd_Number_Of_Lines()
        {
            var inputLines = new string[] { "hello World", "your text will be", "reversed now" };

            var expectedOutput = new string[] { "wello World", "eour text will by", "reversed noh" };

            var actualOutput = ReverseFile.FileReverse.ReverseLines(inputLines);

            Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        }

        [TestMethod]
        public void Reverse_When_Blank_Line_In_File()
        {
            var inputLines = new string[] { "hello World", "your text will be", "", "reversed now" };

            var expectedOutput = new string[] { "wello World", "eour text will by", "reversed noh" };

            var actualOutput = ReverseFile.FileReverse.ReverseLines(inputLines);

            Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        }

        [TestMethod]
        public void Reverse_One_Line()
        {
            var inputLines = new string[] { "hello World" };

            var expectedOutput = new string[] { "dello Worlh" };

            var actualOutput = ReverseFile.FileReverse.ReverseLines(inputLines);

            Assert.IsTrue(expectedOutput.SequenceEqual(actualOutput));
        }
    }
}