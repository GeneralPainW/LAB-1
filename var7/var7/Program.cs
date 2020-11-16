using System;

namespace var7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = Math.Pow(Math.Cos(3.0 / 8 * Math.PI - a / 4), 2) - Math.Pow(Math.Cos(11.0 / 8 * Math.PI + a / 4), 2);
            double z2 = Math.Sqrt(2) / 2 * Math.Sin(a / 2);
            Console.WriteLine($"Z1: {z1:0.00}\nZ2: {z2:0.00}");
        }
    }
}
