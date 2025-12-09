using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint5.Task0.V17.Lib;

namespace Tyuiu.ReshetovaAA.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);

            FileInfo fi = new FileInfo(path);
            bool actual = fi.Exists;
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}