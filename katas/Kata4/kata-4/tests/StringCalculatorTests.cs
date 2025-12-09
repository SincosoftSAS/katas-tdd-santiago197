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

        // [Fact]
        // public void Calculate_TwoNumbers_ReturnsSum()
        // {
        //     // Ejemplo: "1,2" debe retornar 3
        //     Assert.Equal(3, Calculator.Calculate("1,2"));
        // }
    }
}