using System;

namespace ArithmeticLib
{
    public static class Arithmetic
    {
        public static double Add(double A, double B)
        {
            return A + B;
        }

        public static double Subtraction(double A, double B)
        {
            return A - B;
        }

        public static double Division(double A, double B)
        {
            if (Double.IsInfinity(A/B)) 
                throw new Exception("Div by 0");
            return A / B;
        }

        public static double Multiplication(double A, double B)
        {
            return A * B;
        }
    }
}
