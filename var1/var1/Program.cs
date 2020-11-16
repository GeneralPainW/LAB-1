using System;

namespace var1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            double z2 = 1.0 / 4.0 - 1.0 / 4.0 * Math.Sin(5.0 / 2.0 * Math.PI - 8.0 * a);
            Console.WriteLine($"Z1: {z1:0.00}\nZ2: {z2:0.00}");
        }
    }
}
