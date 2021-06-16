using System;
using TRPO_Lab3.ConsoleApp;
namespace TRPO_Lab3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту");
            double h = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус нижнего основания");
            double r1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус верхнего основания");
            double r2 = Double.Parse(Console.ReadLine());

            double sr = TRPO_Lab3.Lib.Class1.Konus(h, r1, r2);
            Console.WriteLine("Объем усеченного конуса равен:" + sr);

        }
    }
}
