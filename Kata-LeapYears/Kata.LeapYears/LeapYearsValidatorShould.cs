using NUnit.Framework;

namespace Kata.LeapYears
{
    [TestFixture]
    public class LeapYearsValidatorShould
    {
        [TestCase(2000, true)]
        [TestCase(2400, true)]
        [TestCase(1824, true)]
        [TestCase(1828, true)]
        [TestCase(1932, true)]
        [TestCase(1988, true)]
        [TestCase(1992, true)]
        [TestCase(1896, true)]
        [TestCase(2012, true)]
        [TestCase(1804, true)]
        [TestCase(2400, true)]
        [TestCase(2019, false)]
        [TestCase(1800, false)]
        [TestCase(1801, false)]
        [TestCase(1905, false)]
        [TestCase(2100, false)]
        [TestCase(1983, false)]
        [TestCase(1601, false)]
        [TestCase(1700, false)]
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
            return !YearIsDivisibleBy(year, 100) || YearIsDivisibleBy(year, 400);
        }

        private static bool YearIsDivisibleBy(int year, int divisor)
        {
            return year % divisor == 0;
        }
    }
}
