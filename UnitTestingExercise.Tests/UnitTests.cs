using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5 , 10)]//Add test data <-------
        [InlineData(2, 4, 6, 12)]
        [InlineData(1, 8, 9, 18)]
        [InlineData(6, 1, 7, 14)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            // create a Calculator object
            var c = new Calculator(); // storing class in a variable with the keyword new infront

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);
            
            //Assert
              Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(29, 20, 9)]//Add test data <-------
        [InlineData(40, 13, 27)]
        [InlineData(10, 3, 7)]
        [InlineData(12, 5, 7)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange (create an instsnce) 
            var S = new Calculator();

            //Act(call the method // instance name.method name(parameters) and store it in a variable.
            var actual = S.Sub(minuend, subtrhend);

            //Assert (Assert.Equal(whats expected to happen, actual);)
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(6, 12, 72)]
        [InlineData(5, 5, 25)]
        [InlineData(10, 12, 120)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var m = new Calculator();

            //Act
            var actual = m.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(33, 11, 3)]//Add test data <-------
        [InlineData(12, 1, 12)]
        [InlineData(40, 10, 4)]
        [InlineData(27, 9, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var d = new Calculator();
            //Act
            var actual = d.divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
