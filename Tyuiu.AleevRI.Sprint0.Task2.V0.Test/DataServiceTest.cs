using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AleevRI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVailed()
        {
            var name = "Руслан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Руслан", res);
        }
    }
}
