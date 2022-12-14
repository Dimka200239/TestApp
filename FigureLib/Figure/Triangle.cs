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
        public double firstSide
        {
            get { return firstSide; }
            private set
            {
                if (value > 0)
                {
                    firstSide = value;
                }
                else
                {
                    throw new Exception("Длина стороны не может быть <= 0");
                }
            }
        }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double secondSide
        {
            get { return secondSide; }
            private set
            {
                if (value > 0)
                {
                    secondSide = value;
                }
                else
                {
                    throw new Exception("Длина стороны не может быть <= 0");
                }
            }
        }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double thirdSide
        {
            get { return thirdSide; }
            private set
            {
                if (value > 0)
                {
                    thirdSide = value;
                }
                else
                {
                    throw new Exception("Длина стороны не может быть <= 0");
                }
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (CheckSides(firstSide, secondSide, thirdSide))
            {
                this.firstSide = firstSide;
                this.secondSide = secondSide;
                this.thirdSide = thirdSide;
            }
            else
            {
                throw new Exception($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} сущестовать не может");
            }
        }

        /// <summary>
        /// Метод для нахождения площади треугольника через три стороны
        /// </summary>
        /// <returns>Значение площади треугольника</returns>
        public override double findArea()
        {
            var p = (firstSide + secondSide + firstSide);

            return Math.Pow(p * (p - firstSide) * (p - thirdSide), 0.5);
        }

        /// <summary>
        /// Метод проверки является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true - если треугольник прямоугольный, иначе false</returns>
        public bool IsTheTriangleRightAndled()
        {
            if (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) &&
                Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) &&
                Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод проверки на сущестование треугольника
        /// </summary>
        /// <returns>true - если существование такого треугольника возможена, иначе false </returns>
        public bool CheckSides(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide > secondSide + thirdSide && secondSide > firstSide + thirdSide && thirdSide > firstSide + secondSide)
            {
                return true;
            }

            return false;
        }
    }
}
