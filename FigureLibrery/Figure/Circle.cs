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
        public  double radius { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">Длина радиуса окружности</param>
        public Circle(string radius)
        {
            if (CheckNumb(radius))
            {
                if (CheckSize(Convert.ToDouble(radius)))
                {
                    this.radius = Convert.ToDouble(radius);
                }
                else
                {
                    throw new Exception("Радиус не может быть <= 0");
                }
            }
            else
            {
                throw new Exception("Некорректное значение радиуса");
            }
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
