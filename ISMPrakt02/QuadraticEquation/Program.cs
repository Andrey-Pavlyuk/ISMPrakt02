using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x;
            while (true) {

                Console.Write("Введите число a: ");
                bool checkA = double.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите число b: ");
                bool checkB = double.TryParse(Console.ReadLine(), out b);
                Console.Write("Введите число c: ");
                bool checkC = double.TryParse(Console.ReadLine(), out c);

                if (checkA && checkB && checkC)
                {
                    double D = Math.Pow(b, 2) - 4 * a * c;
                    if (D >= 0)
                    {
                        if (D > 0)
                        {
                            x1 = (-b + Math.Sqrt(D)) / (2 * a);
                            x2 = (-b - Math.Sqrt(D)) / (2 * a);
                            Console.WriteLine($"\nx1 = {x1}, x2 = {x2}, Дискриминант = {D}");
                        }
                        else
                        {
                            x = -b / (2 * a);
                            Console.WriteLine($"\nx = {x}, Дискриминант = {D}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nНету корней!, Дискриминант = {D}");
                    }
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
