using System;
using Tyuiu.ReshetovaAA.Sprint5.Task3.V2.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл             *");
            Console.WriteLine("* Задание #3                                                      *");
            Console.WriteLine("* Вариант 2                                                       *");
            Console.WriteLine("* Выполнила: Решетова Арина, СМАРТб-25-1                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                        *");
            Console.WriteLine("* y = e^x / x. Вычислить при x = 3.                               *");
            Console.WriteLine("* Округлить до 3 знаков и сохранить в OutPutFileTask3.bin         *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                    *");
            Console.WriteLine("*******************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}