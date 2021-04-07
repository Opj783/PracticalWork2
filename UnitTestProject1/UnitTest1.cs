using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticalWork2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Division()
        {
            // Значення які будуть передані в метод
            double a = 33;
            double b = 16.5;
            //очікуваний результат
            double expected = 2;
            MathOperations object1 = new MathOperations();
            double actual = object1.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication()
        {
            // Значення які будуть передані в метод
            double a = 33;
            double b = 15.5;
            //очікуваний результат
            double expected = 511.5;
            MathOperations object2 = new MathOperations();
            double actual = object2.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
