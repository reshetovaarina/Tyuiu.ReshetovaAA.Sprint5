using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.ReshetovaAA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\777\source\repos\Tyuiu.ReshetovaAA.Sprint5\Tyuiu.ReshetovaAA.Sprint5.Task7.V12\bin\Debug\net8.0\OutPutDataFileTask7V12.txt" ;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}