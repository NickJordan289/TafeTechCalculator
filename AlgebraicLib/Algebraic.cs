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
            return Math.Pow(v, 1.0/3.0);
        }

        public static double Inverse(double v)
        {
            if (v == 0.0)
                throw new Exception("Inverse 0 not valid");
            return 1.0/v;
        }
    }
}