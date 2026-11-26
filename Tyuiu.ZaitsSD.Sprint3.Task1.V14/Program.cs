using Tyuiu.ZaitsSD.Sprint3.Task1.V14.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task1.V14
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда при t = 0,7, используя цикл while.                 *");
            Console.WriteLine("* S = сумма (t^k + 1/(k+1)) * cos(t) для k от 1 до 14.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            int StartValue = 1;
            int StopValue = 14;
            Console.WriteLine($"Значение t = {t}");
            Console.WriteLine($"Стартовое значение = {StartValue}");
            Console.WriteLine($"Конечное значение = {StopValue}");
            double res = ds.GetSumSeries(t, StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {res}");

        }
    }
}
