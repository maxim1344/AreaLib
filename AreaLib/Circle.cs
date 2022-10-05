using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Circle : Figure
    {
        public double Radius { get; } // радиус круга

        #region Круг + проверка корректного ввода данных

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException($"Ошибка: Радиус не может иметь отрицательное значение\nПроверьте введенные параметры");

            Radius = radius;
        }
        #endregion

        #region Вычисление площади круга

        public override double CalcArea()
        {
            return Math.Round(Math.PI * Radius * Radius,2);
        }
        #endregion

    }
}
