using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib.Figure
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double firstSide { get; private set; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double secondSide { get; private set; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double thirdSide { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        public Triangle(string firstSide, string secondSide, string thirdSide)
        {
            if (CheckNumb(firstSide) && CheckNumb(secondSide) && CheckNumb(thirdSide))
            {
                if (CheckSides(Convert.ToDouble(firstSide), Convert.ToDouble(secondSide), Convert.ToDouble(thirdSide)))
                {
                    this.firstSide = Convert.ToDouble(firstSide);
                    this.secondSide = Convert.ToDouble(secondSide);
                    this.thirdSide = Convert.ToDouble(thirdSide);
                }
                else
                {
                    throw new Exception($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} существовать не может");
                }
            }
            else
            {
                throw new Exception($"Некорректное значение сторон треугольника");
            }
        }

        /// <summary>
        /// Метод для нахождения площади треугольника через три стороны
        /// </summary>
        /// <returns>Значение площади треугольника</returns>
        public override double findArea()
        {
            var p = (firstSide + secondSide + thirdSide) / 2;

            return Math.Pow(p * (p - firstSide) * (p - secondSide) * (p - thirdSide), 0.5);
        }

        /// <summary>
        /// Метод проверки является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true - если треугольник прямоугольный, иначе false</returns>
        public bool IsTheTriangleRightAndled()
        {
            if (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) ||
                Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) ||
                Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод проверки на сущестование треугольника
        /// </summary>
        /// <returns>true - если существование такого треугольника возможно, иначе false </returns>
        public bool CheckSides(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
            {
                if (CheckSize(firstSide) && CheckSize(secondSide) && CheckSize(thirdSide))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
