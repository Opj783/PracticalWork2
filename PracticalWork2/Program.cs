using System;

namespace PracticalWork2
{
    public class MathOperations {
        public double Division(double a, double b)
        {
            return a/b;
        }
        public double Multiplication (double a, double b)
        {
            return a * b;
        }
        public double Subtraction (double a, double b)
        {
            return a - b;
        }
        public double Addition (double a, double b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations obj1 = new MathOperations();
            Console.WriteLine(obj1.Division(33, 16.5));
            Console.WriteLine(obj1.Multiplication(15.5, 33));
            Console.WriteLine(obj1.Subtraction(15.5, 33));
            Console.WriteLine(obj1.Addition(15.5, 33));
        }
    }
}
