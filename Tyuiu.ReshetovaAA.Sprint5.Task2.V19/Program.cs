using System;
using Tyuiu.ReshetovaAA.Sprint5.Task2.V19.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Решетова А. | СМАРТб-25-1";

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* Спринт #5                                                       *");
            Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл          *");
            Console.WriteLine("* Задание #2                                                      *");
            Console.WriteLine("* Вариант 19                                                      *");
            Console.WriteLine("* Выполнила: Решетова Арина, СМАРТб-25-1                          *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                        *");
            Console.WriteLine("* Дан массив 3x3. Заменить нечётные элементы на 0.                *");
            Console.WriteLine("* Сохранить в OutPutFileTask2.csv                                 *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                    *");
            Console.WriteLine("*******************************************************************");

            int[,] mtrx =
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}