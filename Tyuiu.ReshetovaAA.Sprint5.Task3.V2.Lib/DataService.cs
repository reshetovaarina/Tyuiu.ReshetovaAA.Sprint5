using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ReshetovaAA.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int x)
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask3.bin");

            double y = Math.Exp(x) / x;
            y = Math.Round(y, 3);

            using (BinaryWriter writer =
                new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}