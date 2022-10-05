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

            while (run)
            {
                Console.Write("Введите 1 для вычисления площади круга, введите 2 для вычисления площади треугольника: ");
                var choose = Console.ReadLine();

                if (choose == "1")
                {
                    Console.Write("Введите радиус круга: ");
                    var radius = Convert.ToDouble(Console.ReadLine());

                    var newFigure = new Circle(radius);

                    Console.WriteLine($"Площадь круга = {newFigure.findArea()}");
                }
                else if (choose == "2")
                {
                    Console.Write("Введите длину 1-ой стороны: ");
                    var firstSide = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите длину 2-ой стороны: ");
                    var secondSide = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите длину 3-ей стороны: ");
                    var thirdSide = Convert.ToDouble(Console.ReadLine());

                    var newFigure = new Triangle(firstSide, secondSide, thirdSide);

                    Console.WriteLine($"Площадь треугольника = {newFigure.findArea()}");
                    Console.WriteLine($"Треугольник прямоугольный? Ответ: {newFigure.IsTheTriangleRightAndled()}");
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
