using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 1, 1, 3)]
        [InlineData(2, 2, 2, 6)]
        [InlineData(3, 3, 3, 9)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);
            

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(9, 6, 3)]
        [InlineData(5, 4, 1)]
        [InlineData(6, 3, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator subtract = new Calculator();
            //Act
            int actual = subtract.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 1, 5)]//Add test data <-------
        [InlineData(6, 5, 30)]
        [InlineData(4, 4, 16)]
        [InlineData(3, 3, 9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator multiply = new Calculator();

            //Act
            int actual = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]//Add test data <-------
        [InlineData(10, 5, 2)]
        [InlineData(20, 5, 4)]
        [InlineData(16, 4, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator divide = new Calculator();

            //Act
            int actual = divide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
