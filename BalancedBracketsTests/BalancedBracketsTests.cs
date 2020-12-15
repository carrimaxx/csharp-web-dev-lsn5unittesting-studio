using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add at least 12 tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void PairedMultipleBracketsOnlyStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][][]"));
        }


        [TestMethod]
        public void PairedBracketsInBothEndsOfStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void PairedBracketsInBetweenStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void LongStringWithMultiplePairedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code][CSharp]"));
        }

        [TestMethod]
        public void EmptyBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(""));
         }

        [TestMethod]
        public void NoBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launchcode"));
        }

        [TestMethod]
        public void UnpairedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch["));
        }

        [TestMethod]
        public void ReversedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void UnpairedBracketsInBetweenStringReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch[Code] [Web Development"));
        }

        [TestMethod]
        public void ReversedBracketsInBetweenStringsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch][Code"));
        }

        [TestMethod]
        public void UnpairedMultipleBracketsOnlyStringReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[][][]["));
        }

        [TestMethod]
        public void StringWithNoSquareBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("{LaunchCode}"));
        }
    }
}
