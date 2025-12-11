using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V12.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    strLine = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        char ch = line[i];

                        if (char.IsLetter(ch))
                        {
                            ch = char.ToUpper(ch);
                        }

                        strLine += ch;
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}