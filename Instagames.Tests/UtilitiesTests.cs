using System;
using Instagames.WebApp.Helpers;
using NUnit.Framework;

namespace Instagames.Tests
{
    [TestFixture]
    public class UtilitiesTests
    {
        [Test]
        public static void SummarizeTextTest()
        {
            var text = "Have a nice Day Coding";
            var maxLength = 15;
            var result = Utilities.SummarizeText(text, maxLength);

            Assert.That(result, Is.EqualTo("Have a nice Day..."));
        }

        [Test]
        public static void CalculateAgeTests()
        {
            var testDate = DateTime.Now.Year - 26;
            var dateOfBirth = new DateTime(testDate, 10,28);
            var age = Utilities.CalculateAge(dateOfBirth);

            Assert.That(age, Is.EqualTo(25));
        }
    }
}
