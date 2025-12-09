using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V18.txt";

            FileInfo fi = new FileInfo(path);

            bool fileExists = fi.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}