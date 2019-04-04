using System;

namespace TrigonometricLib
{
    public static class Trigonometric
    {
        // Defaults is radians
        // Converts to degrees when radians=false
        public static double Tan(double a, bool radians)
        {
            if(!radians)
            {
                if (a == 90.0 || a == 270.0) // undefined values
                {
                    throw new Exception("Undefined values in tan");
                }
                else
                {
                    a = a * Math.PI / 180.0; // convert to radians
                }
            }
            return Math.Tan(a);
        }

        // Defaults is radians
        // Converts to degrees when radians=false
        public static double Sine(double a, bool radians)
        {
            if (!radians)
            {
                a = a * Math.PI / 180.0;
            }
            return Math.Sin(a);
        }

        // Defaults is radians
        // Converts to degrees when radians=false
        public static double Cosine(double a, bool radians)
        {
            if (!radians)
            {      
                    a = a * Math.PI / 180.0; // convert to radians
            }
            return Math.Cos(a);
        }
    }
}
