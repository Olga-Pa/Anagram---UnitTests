using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Task1.Tests
{
    [TestClass]
    public class AnagramTests
    {
        private Anagram anagram = new Anagram();
        [Test]
        public void Reverse_SentanceMatching_RunsTrue_1()
        {
            Assert.AreEqual("  d1cba    hgf!e  ", anagram.Reverse("  a1bcd    efg!h  "));
        }
        [TestMethod]
        public void Reverse_SentanceMatching_RunsTrue_2()
        {
            Assert.AreEqual("   1cb# hgf!e", anagram.Reverse("   1bc# efg!h"));
        }
        [TestMethod]
        public void Reverse_SentanceMatching_RunsTrue_3()
        {
            Assert.AreEqual("  d1cba    hgf!e  #$", anagram.Reverse("  a1bcd    efg!h  #$"));
        }
        [TestMethod]
        public void ReverseWord_NotValid_RunsTrue()
        {
            Assert.AreEqual(null, anagram.Reverse(null));
        }

        [TestMethod]
        public void ReverseWord_NotEmpty_RunsTrue()
        {
            Assert.AreEqual(null, anagram.Reverse(""));
        }

    }
}
