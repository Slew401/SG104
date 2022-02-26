using NUnit.Framework;
using Movies;
namespace TestProject1
{
    public class Tests
    {
        
        [TestCase(11, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        public void Test1(int age, string response)
        {
            Assert.That(response, Is.EqualTo(MovieClass.AvailableClassifications(age)));
        }
    }
}