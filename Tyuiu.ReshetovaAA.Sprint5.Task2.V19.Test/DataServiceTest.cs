using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint5.Task2.V19.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int[,] mtrx = { { 9, 2, 5 }, { 8, 8, 2 }, { 7, 4, 8 } };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}