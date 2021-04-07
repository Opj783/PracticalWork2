using PracticalWork2;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Subtraction()
        {
            // Значення які будуть передані в метод
            double a = 33;
            double b = 15.5;
            //очікуваний результат
            double expected = 17.5;
            MathOperations object1 = new MathOperations();
            double actual = object1.Subtraction(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition()
        {
            // Значення які будуть передані в метод
            double a = 15.5;
            double b = 33;
            //очікуваний результат
            double expected = 48.5;
            MathOperations object2 = new MathOperations();
            double actual = object2.Addition(a, b);
            Assert.Equal(expected, actual);
        }

    }
}
