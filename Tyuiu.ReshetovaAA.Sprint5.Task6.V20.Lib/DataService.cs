using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    char[] separators = { ' ', '\t', ',', '.', '!', '?', ';', ':', '-', '«', '»', '(', ')', '"', '\'' };

                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}