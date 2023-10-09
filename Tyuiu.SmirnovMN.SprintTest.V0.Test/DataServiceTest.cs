using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SmirnovMN.SprintTest.V0.Lib;

namespace Tyuiu.SmirnovMN.SprintTest.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет!?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}

