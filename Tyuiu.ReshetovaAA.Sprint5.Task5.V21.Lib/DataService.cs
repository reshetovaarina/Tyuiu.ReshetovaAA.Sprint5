using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double maxEven = 0; 

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] nums = line.Split(' ');

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == "")
                            continue;

                        string s = nums[i].Replace(".", ",");

                        double value = Convert.ToDouble(s);

                        if (value % 1 == 0 && value % 2 == 0)
                        {
                            if (value > maxEven)
                            {
                                maxEven = value;
                            }
                        }
                    }
                }
            }

            double res = 1;

            for (int i = 1; i <= maxEven; i++)
            {
                res = res * i;
            }

            res = Math.Round(res, 3);
            return res;
        }
    }
}