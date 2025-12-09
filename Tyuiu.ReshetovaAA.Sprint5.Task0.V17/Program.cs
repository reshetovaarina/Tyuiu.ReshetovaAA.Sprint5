using System;
using Tyuiu.ReshetovaAA.Sprint5.Task0.V17.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* Спринт #5                                                   *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл            *");
            Console.WriteLine("* Задание #0                                                  *");
            Console.WriteLine("* Вариант 17                                                  *");
            Console.WriteLine("* Выполнила: Решетова Арина                                   *");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                    *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1          *");
            Console.WriteLine("* Вычислить при x = 3. Округлить до 3 знаков.                 *");
            Console.WriteLine("* Сохранить результат в OutPutFileTask0.txt                   *");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                *");
            Console.WriteLine("***************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                  *");
            Console.WriteLine("***************************************************************");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}