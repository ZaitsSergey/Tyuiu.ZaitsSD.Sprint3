using Tyuiu.ZaitsSD.Sprint3.Task0.V10.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task0.V10
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить произведение ряда при x = 5, используя цикл for.              *");
            Console.WriteLine("* p = произведение (300 / (i + x^i))^i для i от 1 до 5.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Value = 5;
            int StartValue = 1;
            int StopValue = 5;
            Console.WriteLine($"Значение X = {Value}");
            Console.WriteLine($"Старт шага = {StartValue}");
            Console.WriteLine($"Стоп шага = {StopValue}");
            double res = ds.GetMultiplySeries(Value, StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда = {res}");

        }
    }
}
