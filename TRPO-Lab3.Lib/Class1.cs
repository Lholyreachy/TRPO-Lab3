using System;

namespace TRPO_Lab3.Lib
{
    public class Class1
    {
        public static double Konus(double h, double r1, double r2)
          
        {
            double Konus = Math.PI * h * (Math.Pow(r1, 2) + r1 * r2 + Math.Pow(r2, 2))/3;
            return Konus; 

        }
    }
}
