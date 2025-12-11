using System;
using Tyuiu.ReshetovaAA.Sprint5.Task7.V12.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл             *");
            Console.WriteLine("* Задание #7                                                      *");
            Console.WriteLine("* Вариант 12                                                      *");
            Console.WriteLine("* Выполнила: Решетова Арина                                       *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                    *");
            Console.WriteLine("*******************************************************************");


            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                   *");
            Console.WriteLine("************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат сохранён в файле: " + pathSaveFile);

            Console.ReadKey();
        }
    }
}