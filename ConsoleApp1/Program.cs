using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLib.Figure;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var run = true;

            Console.WriteLine("ДЛЯ ВВОДА ЧИСЕЛ С ДЕСЯТИЧНЫМИ ДРОБЯМИ ВМЕСТО \".\" ИСПОЛЬЗУЙТЕ \",\"\n");

            while (run)
            {
                Console.Write("Введите 1 для вычисления площади круга, введите 2 для вычисления площади треугольника: ");
                var choose = Console.ReadLine();

                if (choose == "1")
                {
                    try
                    {
                        Console.Write("Введите радиус круга: ");
                        var radius = Console.ReadLine();

                        var newFigure = new Circle(radius);

                        Console.WriteLine($"Площадь круга = {newFigure.findArea()}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else if (choose == "2")
                {
                    try
                    {
                        Console.Write("Введите длину 1-ой стороны: ");
                        var firstSide = Console.ReadLine();
                        Console.Write("Введите длину 2-ой стороны: ");
                        var secondSide = Console.ReadLine();
                        Console.Write("Введите длину 3-ей стороны: ");
                        var thirdSide = Console.ReadLine();

                        var newFigure = new Triangle(firstSide, secondSide, thirdSide);

                        Console.WriteLine($"Площадь треугольника = {newFigure.findArea()}");
                        Console.WriteLine($"Треугольник прямоугольный? Ответ: {newFigure.IsTheTriangleRightAndled()}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Неизвестная команда");
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
