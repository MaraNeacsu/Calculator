using Xunit;

namespace CalculatorXUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            double a = 5, b = 3;

            // Act
            double result = Calculator.CalculatorApp.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            double a = 10, b = 4;

            // Act
            double result = Calculator.CalculatorApp.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ByZero_ReturnsNaN()
        {
            // Arrange
            double a = 5, b = 0;

            // Act
            double result = Calculator.CalculatorApp.Divide(a, b);

            // Assert
            Assert.True(double.IsNaN(result));
        }
    }
}
