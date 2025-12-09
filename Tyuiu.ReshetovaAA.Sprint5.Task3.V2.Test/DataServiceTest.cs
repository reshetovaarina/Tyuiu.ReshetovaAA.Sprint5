using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint5.Task3.V2.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);

            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}