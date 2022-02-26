using NUnit.Framework;
using VowelCounter;

namespace VowelsTest
{
    public class Tests
    {
        
        [TestCase("Hello,World!", 3)]
        [TestCase("Stanni Lewis", 4)]
        [TestCase("", 0)]
        [TestCase("QWRTYPSDFGHJKLZXCVBNM", 0)]
        [TestCase("AEIOU", 5)]
        [TestCase("Boopadadjdpqeqcikaksdasldasd", 9)]
        public void Test1(string str, int vowelCount)
        {
            Assert.That(vowelCount, Is.EqualTo(Vowels.countVowels(str)));
        }
    }
}