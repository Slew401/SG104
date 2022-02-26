using Movies;
using NUnit.Framework;
namespace TestProject2
{
    public class Tests
    {
        [TestCase(11, "U, PG & 12 films are available.")]
        public void Test1(int age, string response)
        {
            Assert.That(response, Is.EqualTo(MovieClass.AvailableClassifications(age)));
        }
    }
}