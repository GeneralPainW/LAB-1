using System;

namespace var5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = 1.0 - (1.0 / 4.0) * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);
            double z2 = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
            Console.WriteLine($"Z1: {z1:0.00}\nZ: {z2:0.00}");
        }
    }
}
