using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib.Figure
{
    public class Circle : Figure
    {
        /// <summary>
        /// Поле для хранения длины радиуса окружности
        /// </summary>
        public  double radius
        {
            get { return radius; }
            private set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Радиус окружности не может быть <= 0");
                }
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">Длина радиуса окружности</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Метод для нахождения площади окружности
        /// </summary>
        /// <returns>Значение площади окружности</returns>
        public override double findArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
