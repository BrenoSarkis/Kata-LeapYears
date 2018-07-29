using NUnit.Framework;

namespace Kata.LeapYears
{
    [TestFixture]
    public class LeapYearsValidatorShould
    {
        [Test]
        public void ValidateLeapYears()
        {
            Assert.That(LeapYearsValidator.IsLeapYear(2000), Is.EqualTo(true));
            Assert.That(LeapYearsValidator.IsLeapYear(2019), Is.EqualTo(false));
        }
    }

    public class LeapYearsValidator
    {
        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0;
        }
    }
}
