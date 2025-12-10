using FluentAssertions;

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

        [Fact]
        public void Calculate_MultipleNumberNumbers_ReturnsSum()
        {
            Assert.Equal(15, Calculator.Calculate("1,2,3,4,5"));
        }

        [Fact]
        public void Calculate_NumbersWithLines_ReturnsSum()
        {
            Assert.Equal(6, Calculator.Calculate("1\n2,3"));
        }

        [Fact]
        public void Calculate_NumbersWithCustomDelimiter_ReturnsSum()
        {
            Assert.Equal(3, Calculator.Calculate("//;\n1;2"));
        }

        [Fact]
        public void Calculate_NumbersNegative_ReturnsException()
        {
            Action caller = () => Calculator.Calculate("1,-2,3,-4");
            caller.Should().ThrowExactly<InvalidOperationException>().WithMessage("Negatives not allowed: [-2, -4]");
        }

        [Fact]
        public void Calculate_NumbersGreaterThan1000Ignore_ReturnsSum()
        {
            Assert.Equal(2, Calculator.Calculate("2,1001"));
        }
    }
}