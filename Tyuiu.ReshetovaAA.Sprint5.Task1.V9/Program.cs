using System;
using Tyuiu.ReshetovaAA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл         *");
            Console.WriteLine("* Задание #1                                                      *");
            Console.WriteLine("* Вариант 9                                                       *");
            Console.WriteLine("* Выполнила: Решетова Арина, СМАРТб-25-1                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                        *");
            Console.WriteLine("* F(x) = sin(x) + cos(2x)/2 - 1,5x                                *");
            Console.WriteLine("* Табулировать на [-5; 5] с шагом 1.                              *");
            Console.WriteLine("* При делении на ноль вернуть 0.                                 *");
            Console.WriteLine("* Сохранить результат в OutPutFileTask1.txt.                      *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.               *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                    *");
            Console.WriteLine("*******************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue  = " + stopValue);

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}