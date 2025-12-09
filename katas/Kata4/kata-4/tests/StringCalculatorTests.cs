namespace Kata4.tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate_EmptyString_ReturnsZero()
        {
            var result = Calculator.Calculate("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Calculate_OneNumber_ReturnsNumber()
        {
            var result = Calculator.Calculate("1");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            Assert.Equal(3, Calculator.Calculate("1,2"));
        }
    }
}