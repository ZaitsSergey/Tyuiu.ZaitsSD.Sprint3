
using Tyuiu.ZaitsSD.Sprint3.Task3.V11.Lib;
namespace Tyuiu.ZaitsSD.Sprint3.Task3.V11
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Заиц Сергей Денисович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, заменить буквы q на цифру 7                     *");
            Console.WriteLine("* в строке sqwreq vqwqq q.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string Text = "sqwreq vqwqq q";
            Console.WriteLine($"Исходная строка: {Text}");
            char Symbol = 'q';
            char Replacement = '7';
            string res = ds.ReplaceCharOnNum(Text, Symbol, Replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Строка после замены: {res}");

        }
    }
}
