using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint5.Task1.V9.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}