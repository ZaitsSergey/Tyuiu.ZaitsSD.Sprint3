
using Tyuiu.ZaitsSD.Sprint3.Task4.V18.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task4.V18
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить y = sin(x)/cos(x) на отрезке от -5 до 5.                      *");
            Console.WriteLine("* При x = 0 прервать цикл. Полученные значения суммировать.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = -5;
            int StopValue = 5;
            Console.WriteLine($"Отрезок от {StartValue} до {StopValue}");
            Console.WriteLine("Функция: y=sin(x)/cos(x)");
            double res = ds.Calculate(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма значений функции = {res}");

        }
    }
}
