using ExceptionProject;
using NUnit.Framework;
using System;

namespace ExceptionTesting
{
    public class Tests
    {
        [Category("Lower Bound Tests Less Than Zero")]
        [TestCase(-34)]
        [TestCase(-50)]
        public void Test1(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Mark must be between 0 and 100 inclusive"));
        }

        [Category("Greater Than 100 Tests")]
        [TestCase(101)]
        [TestCase(1000)]
        public void HigherBoundTest(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Mark must be between 0 and 100 inclusive"));
        }
    }
}