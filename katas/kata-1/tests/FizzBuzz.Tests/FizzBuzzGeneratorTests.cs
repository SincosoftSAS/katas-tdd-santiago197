using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);

            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithTwo()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(2);

            // Assert
            result.Should().HaveCount(2);
            result.Should().BeEquivalentTo(["1", "2"]);
        }

        [Fact]
        public void Generate_WithThree_ReturnsListWithOneTwoAndFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);

            // Assert
            result.Should().HaveCount(3);
            result.Should().BeEquivalentTo(["1", "2", "Fizz"]);
        }

        [Fact]
        public void Generate_WithFive_ReturnsListWithOneTwoFizzFourAndBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);

            // Assert
            result.Should().HaveCount(5);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz"]);
        }

        [Fact]
        public void Generate_WithMultipleOfThree_ReturnsListWithNumbersAndFizzMultiplesOfThree()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(6);

            // Assert
            result.Should().HaveCount(6);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz", "Fizz"]);
        }

        [Fact]
        public void Generate_WithMultipleOfFive_ReturnsListWithNumbersAndBuzzMultiplesOfFive()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(10);

            // Assert
            result.Should().HaveCount(10);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]);
        }

        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);

            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }

        [Fact]
        public void GenerateMultipleOf15ReturnsFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(100);

            // Assert
            result.Should().HaveCount(100);
            result[29].Should().Be("FizzBuzz");
        }
    }
}