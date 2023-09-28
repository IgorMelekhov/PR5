//Практическая работа номер 2
// Выполнил: Мелехов И.В
// Задание: Выяснить, пройдет ли кирпич в отверстие
using System;

namespace PR5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int длина, ширина, высота, нижняя_сторона_отверстия, боковая_сторона_отверстия;
            Console.WriteLine("Практическая работа номер 5");
            Console.Write("Введите пять значений: \n");
            Console.Write("длина=");
            длина = Convert.ToInt32(Console.ReadLine());
            Console.Write("ширина=");
            ширина = Convert.ToInt32(Console.ReadLine());
            Console.Write("высота=");
            высота = Convert.ToInt32(Console.ReadLine());
            Console.Write("нижняя_сторона_отверстия=");
            нижняя_сторона_отверстия = Convert.ToInt32(Console.ReadLine());
            Console.Write("боковая_сторона_отверстия=");
            боковая_сторона_отверстия = Convert.ToInt32(Console.ReadLine());

            if (длина <= нижняя_сторона_отверстия)
            {
                if (высота <= боковая_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет");
                else Console.WriteLine("Кирпич не пройдет");
            }
            if (длина <= боковая_сторона_отверстия)
            {
                if (высота <= нижняя_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет ");
                else Console.WriteLine("Кирпич не пройдет");
            }
            if (длина <= боковая_сторона_отверстия)
            {
                if (ширина <= нижняя_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет ");
                else Console.WriteLine("Кирпич не пройдет");
            }
            if (длина <= нижняя_сторона_отверстия)
            {
                if (ширина <= боковая_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет ");
                else Console.WriteLine("Кирпич не пройдет");
            }
            if (ширина <= боковая_сторона_отверстия)
            {
                if (высота <= нижняя_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет ");
                else Console.WriteLine("Кирпич не пройдет");
            }
            if (высота <= боковая_сторона_отверстия)
            {
                if (ширина <= нижняя_сторона_отверстия)
                    Console.WriteLine("Кирпич пройдет ");
                else Console.WriteLine("Кирпич не пройдет");
            }
            else Console.WriteLine("Кирпич не пройдет");
            Console.ReadKey();

        }
    }
}