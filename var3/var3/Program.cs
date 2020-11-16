using System;

namespace var3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) /
                (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
            double z2 = 2 * Math.Sin(a);
            Console.WriteLine($"Z1: {z1:0.00}\nZ2: {z2:0.00}");
        }
    }
}
