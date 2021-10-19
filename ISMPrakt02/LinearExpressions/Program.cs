using System;

namespace LinearExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x, y, z, r;
            while (true)
            {
                Console.Write("Введите число a: ");
                bool checkA = double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите число b: ");
                bool checkB = double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите число c: ");
                bool checkC = double.TryParse(Console.ReadLine(), out c);
                Console.Write("Введите число d: ");
                bool checkD = double.TryParse(Console.ReadLine(), out d);

                if (checkA && checkB && checkC && checkD)
                {
                    x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
                    y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + ((Math.Pow(d, 2) * (a * a - b * b)) / (b - a));
                    z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
                    r = ((0.5 * a + 0.75 * b - 1.4) / (3 * c + 1)) + (1 / (a - c));
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
                    Console.WriteLine($"x = {x}, y = {y}, z = {z}, r = {r}");
                    break;
                }
                else
                {
                    Console.WriteLine("\nВведите числа еще раз!\n");
                }
            }
        }
    }
}