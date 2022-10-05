using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Triangle : Figure
    {
        public double FirstSide { get; } // первая сторона треугольника
        public double SecondSide { get; } // вторая сторона треугольника
        public double ThirdSide { get; } // третья сторона треугольника

        #region Треугольник + проверка корректного ввода данных      
        
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0) 
                throw new ArgumentException($"Ошибка: Сторона не может быть меньше 0\nПроверьте введенные параметры");

            else if (firstSide > (secondSide + thirdSide)
                || secondSide > (firstSide + thirdSide) 
                || thirdSide > (firstSide + secondSide)) 
                throw new ArgumentException($"Ошибка: одна из сторон больше чем сумма двух других\nПроверьте введенные параметры");

            else
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
        }
        #endregion

        #region Вычисление площади треугольника     
        
        public override double CalcArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide)), 2);
            return result;
        }
        #endregion

        #region Проверка, является ли треугольник прямоугольным

        public bool IsRectangular()
        {
            bool IsRectangular = (FirstSide == Math.Sqrt(Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                         || SecondSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2))
                         || ThirdSide == Math.Sqrt(Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2)));
            return IsRectangular;
        }
        #endregion

    }
}
