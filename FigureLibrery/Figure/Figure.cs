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
    }
}
