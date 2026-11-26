
using Tyuiu.ZaitsSD.Sprint3.Task2.V1.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task2.V1
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда, используя цикл do...while.                        *");
            Console.WriteLine("* S = сумма sin(i) * (1/2)^2 для i от 1 до 10.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = 1;
            int StopValue = 10;
            Console.WriteLine($"Стартовое значение = {StartValue}");
            Console.WriteLine($"Конечное значение = {StopValue}");
            double res = ds.GetSumSeries(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {res}");

        }
    }
}
