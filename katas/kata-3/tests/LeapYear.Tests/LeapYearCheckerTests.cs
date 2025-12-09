using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Fact]
        public void Year_DivisibleBy4_ButNotBy100_IsLeapYear()
        {
            Assert.True(LeapYearChecker.IsLeapYear(2004));
        }

        [Fact]
        public void Year_NotDivisibleBy4_IsNotLeapYear()
        {
            Assert.False(LeapYearChecker.IsLeapYear(2001));
        }

        [Fact]
        public void Year2000_DivisibleBy400_IsLeapYear()
        {
            Assert.True(LeapYearChecker.IsLeapYear(2000));
        }

        [Fact]
        public void Year1900_DivisibleBy100NotDivisibleBy400_IsNotLeapYear()
        {
            Assert.False(LeapYearChecker.IsLeapYear(1900));
        }
    }
}
