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
        }
    }

    public class LeapYearsValidator
    {
        public static bool IsLeapYear(int year)
        {
            return true;
        }
    }
}
