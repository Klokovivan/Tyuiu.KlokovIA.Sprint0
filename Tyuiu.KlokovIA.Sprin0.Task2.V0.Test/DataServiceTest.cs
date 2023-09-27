using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KlokovIA.Sprin0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, метод из библиотек
            var name = "Иван";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Иван", res);
        }
    }
}
