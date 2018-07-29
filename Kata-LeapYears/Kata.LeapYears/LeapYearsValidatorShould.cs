using NUnit.Framework;

namespace Kata.LeapYears
{
    [TestFixture]
    public class LeapYearsValidatorShould
    {
        [TestCase(2000, true)]
        [TestCase(2019, false)]
        [TestCase(1800, false)]
        public void ValidateLeapYears(int year, bool isLeapYear)
        {
            Assert.That(LeapYearsValidator.IsLeapYear(year), Is.EqualTo(isLeapYear));
        }
    }

    public class LeapYearsValidator
    {
        public static bool IsLeapYear(int year)
        {
            if (!YearIsDivisibleBy(year, 4)) return false;
            if (YearIsDivisibleBy(year, 100) && !YearIsDivisibleBy(year, 400)) return false;

            return true;
        }

        private static bool YearIsDivisibleBy(int year, int divisor)
        {
            return year % divisor == 0;
        }
    }
}
