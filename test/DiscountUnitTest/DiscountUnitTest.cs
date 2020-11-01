using Algo_lab_2.src.manager;
using AlgoLab2.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DiscountUnitTest
    {
        [TestMethod]
        public void TestOptimalPriceFinder()
        {
            MyList list = new MyList();
            int[] array = { 50, 20, 30, 17, 100 };
            foreach(var unit in array)
            {
                list.Add(unit);
            }
            decimal discount = 10;
            decimal price = DiscountChooser.FindOptimalPrice(list, discount);
            Assert.AreEqual(207, price);
        }
    }
}
