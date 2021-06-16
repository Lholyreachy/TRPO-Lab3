using System;

namespace TRPO_Lab3.Lib
{
    public class Class1
    {
        public static double Konus(double h, double r1, double r2)
          
        {
            //if (r1 < r2 )

            //    {
            //    throw new Exception("Радиус нижнего основания не может быть меньше, чем радиус верхнего основания");
            //}
            double Konus = Math.PI * h * (Math.Pow(r1, 2) + r1 * r2 + Math.Pow(r2, 2))/3;
            return Konus; 

        }

        public static double Del (int a, int b)
        {
            return a / b;
        }
    }
}
