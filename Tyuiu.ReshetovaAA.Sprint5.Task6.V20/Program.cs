using System;
using Tyuiu.ReshetovaAA.Sprint5.Task6.V20.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова Арина";

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                *");
            Console.WriteLine("* Задание #6                                                      *");
            Console.WriteLine("* Вариант 20                                                      *");
            Console.WriteLine("* Выполнила: Решетова Арина                                       *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
            Console.WriteLine("*******************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            int res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество слов длиной 6 символов = " + res);

            Console.ReadKey();
        }
    }
}