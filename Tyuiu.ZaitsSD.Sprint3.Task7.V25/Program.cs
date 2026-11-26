using Tyuiu.ZaitsSD.Sprint3.Task7.V25.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Заиц С. Д. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вывести таблицу значений F(x) = cos(x) + 4x/2 - sin(x) * 3x             *");
            Console.WriteLine("* на отрезке [-5, 5] с шагом 1. Округлить до двух знаков.                 *");
            Console.WriteLine("* Значения занести в массив. При делении на ноль вернуть 0.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartVal = -5;
            int StopVal = 5;
            Console.WriteLine($"Начало отрезка = {StartVal}");
            Console.WriteLine($"Конец отрезка = {StopVal}");
            double[] res = ds.GetMassFunction(StartVal, StopVal);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X\tF(x)");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{StartVal + i}\t{res[i]}");
            }

        }
    }
}
