using System;
using Tyuiu.ReshetovaAA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                         *");
            Console.WriteLine("* Задание #4                                                      *");
            Console.WriteLine("* Вариант 18                                                      *");
            Console.WriteLine("* Выполнила: Решетова Арина, СМАРТб-25-1                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
            Console.WriteLine("*******************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V18.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("y = " + res);

            Console.ReadKey();
        }
    }
}