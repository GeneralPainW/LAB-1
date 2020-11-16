using System;

namespace var6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = Math.Cos(a) + Math.Cos(2 * a) + Math.Cos(6 * a) + Math.Cos(7 * a);
            double z2 = 4 * Math.Cos(a / 2) * Math.Cos(5.0 / 2 * a) * Math.Cos(4 * a);
            Console.WriteLine($"Z1: {z1:0.00}\nZ2: {z2:0.00}");
        }
    }
}
