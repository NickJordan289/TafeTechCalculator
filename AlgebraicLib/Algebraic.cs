using System;

namespace AlgebraicLib
{
    public static class Algebraic
    {
        public static double SquareRoot(double v)
        {
            if(v < 0)
                throw new Exception("Imaginary number not valid");
            return Math.Sqrt(v);
        }

        public static double CubeRoot(double v)
        {
            if (v < 0)
                throw new Exception("Imaginary number not valid");
            return Math.Ceiling(Math.Pow(v, 1.0/3.0));
        }

        public static double Inverse(double v)
        {
            return 1.0/v;
        }
    }
}