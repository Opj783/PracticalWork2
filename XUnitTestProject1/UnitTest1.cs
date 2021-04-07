using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Plus_4and2()
        {
            // Значення які будуть передані в метод
            int a = 4;
            int b = 2;
            //очікуваний результат
            int expected = 6;
            MathOperations object1 = new MathOperations();
            int actual = object1.Subtraction(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Deduction_4and2()
        {
            // Значення які будуть передані в метод
            int a = 4;
            int b = 2;
            //очікуваний результат
            int expected = 4;
            MathOpertions object2 = new MathOperations();
            int actual = object2.Addition(a, b);
            Assert.Equal(expected, actual);
        }

    }
}
