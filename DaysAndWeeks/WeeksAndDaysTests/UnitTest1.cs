using NUnit.Framework;
using WeeksExercise; 
namespace WeeksAndDaysTests
{
    public class Tests
    {
        [TestCase(8, "1 week/s and 1 day/s")]
        public void Test1(int days, string response)
        {
            Assert.That(response, Is.EqualTo(WeeksAndDays.DaysAndWeeks(days)));
        }
    }
}