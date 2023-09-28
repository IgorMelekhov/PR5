//Практическая работа номер 2
// Выполнил: Мелехов И.В
// Задание: Выяснить, пройдет ли кирпич в отверстие
using System;

namespace temp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool i = false; 
            Console.WriteLine("Зравствуйте,введите пожалуйста пять переменных");

            int lenght, width, height, LowerSide, LateralSide;
            Console.Write("длина =");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.Write("ширина=");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("высота=");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Нижняя Сторона = ");
            LowerSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("Боковая Сторона = ");
            LateralSide = Convert.ToInt32(Console.ReadLine());
            if ((lenght <= LowerSide) && (height <= LateralSide)) 
                i = true; 

            if ((lenght <= LateralSide) && (height <= LowerSide))
            {
                    i = true;
            }
            if ((lenght <= LateralSide)&& (width <= LowerSide))
            {
                    i = true;
            }
            if ((lenght <= LowerSide)&& (width <= LateralSide))
            {
                    i = true;
            }
            if ((width <= LateralSide)&& (height <= LowerSide))
            {
                    i = true;
            }
            if ((height <= LateralSide)&& (width <= LowerSide))
            {
                    i = true;
            }

            if (i) Console.WriteLine("Кирпич пройдет");
            else Console.WriteLine("Кирпич не пройдет");

            Console.ReadKey();

        }
    }
}
