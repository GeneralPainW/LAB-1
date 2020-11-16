using System;

namespace var4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            double z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a))
                / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));
            double z2 = Math.Tan(3.0 * a);
            Console.WriteLine($"Z1: {z1:0.00}\nZ2: {z2:0.00}");
        }
    }
}
