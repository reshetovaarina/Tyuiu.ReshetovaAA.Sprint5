using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            double x = Convert.ToDouble(str);

            double res = Math.Cos(x) + (Math.Pow(x, 2) / 2);

            res = Math.Round(res, 3);

            return res;
        }
    }
}