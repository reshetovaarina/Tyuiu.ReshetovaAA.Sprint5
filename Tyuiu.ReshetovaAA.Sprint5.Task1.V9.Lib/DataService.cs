using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = 2.0;
                if (denom == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + Math.Cos(2 * x) / denom - 1.5 * x;
                }

                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}