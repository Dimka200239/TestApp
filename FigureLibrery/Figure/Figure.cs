using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib.Figure
{
    public class Figure
    {
        /// <summary>
        /// Переопределяемый метод нахождения площади фигуры
        /// </summary>
        public virtual double findArea()
        {
            return 0;
        }

        /// <summary>
        /// Метод проверяет положительно ли значение того или иного размера
        /// </summary>
        /// <returns>true - если значение размера положительное, иначе false</returns>
        public bool CheckSize(double size)
        {
            if (size > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Метод проверяет является ли введеное значение числом
        /// </summary>
        /// <param name="numb">Вводимое значние</param>
        /// <returns>true - если число, иначе false</returns>
        public bool CheckNumb(string numb)
        {
            var iteration = 0;
            var countOfDot = 0;

            if (numb[0] == '-')
            {
                iteration++;
            }

            for (int i = iteration; i< numb.Length; i++)
            {
                if (!char.IsDigit(numb[i]))
                {
                    if (numb[i] == ',' && i != 0)
                    {
                        countOfDot++;
                        continue;
                    }

                    return false;
                }
            }
            if (countOfDot > 1)
            {
                return false;
            }

            return true;
        }
    }
}
