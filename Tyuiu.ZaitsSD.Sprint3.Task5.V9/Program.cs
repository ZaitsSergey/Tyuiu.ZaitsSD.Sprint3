
using Tyuiu.ZaitsSD.Sprint3.Task5.V9.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task5.V9
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму 1/sin(k) по i от 1 до 3                         *");
            Console.WriteLine("* и k от 1 до 14. К полученной сумме прибавить x = 5.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int StartValue1 = 1, StopValue1 = 3;
            int StartValue2 = 1, StopValue2 = 14;
            Console.WriteLine($"Значение x = {x}");
            Console.WriteLine($"Начало первого ряда {StartValue1}");
            Console.WriteLine($"Конец первого ряда {StopValue1}");
            Console.WriteLine($"Начало второго ряда {StartValue2}");
            Console.WriteLine($"Конец второго ряда {StopValue2}");
            double res = ds.GetSumSumSeries(x, StartValue1, StartValue2, StopValue1, StopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Значение функции = {res}");

        }
    }
}
