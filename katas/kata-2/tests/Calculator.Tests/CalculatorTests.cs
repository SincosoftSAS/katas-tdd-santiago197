using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(8);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsResult()
        {
            // Arrange
            int a = 7;
            int b = 4;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(28);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsResult()
        {
            // Arrange
            int a = 20;
            int b = 5;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(4);
        }


        // TODO: Implementa más tests usando TDD
        // Suggestions:
        // - Test multiply with positive numbers
        // - Test divide with positive numbers  
        // - Test edge cases (division by zero, negative numbers, etc.)
    }
}