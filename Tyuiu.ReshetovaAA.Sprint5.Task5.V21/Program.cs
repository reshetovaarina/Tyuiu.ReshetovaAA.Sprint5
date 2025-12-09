using System;
using Tyuiu.ReshetovaAA.Sprint5.Task5.V21.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task5.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова Арина";

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                  *");
            Console.WriteLine("* Задание #5                                                      *");
            Console.WriteLine("* Вариант 21                                                      *");
            Console.WriteLine("* Выполнила: Решетова Арина                                       *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
            Console.WriteLine("*******************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Факториал наибольшего числа = " + res);

            Console.ReadKey();
        }
    }
}