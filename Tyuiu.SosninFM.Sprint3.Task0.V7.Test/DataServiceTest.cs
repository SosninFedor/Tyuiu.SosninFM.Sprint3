
using System.Transactions;
using Tyuiu.SosninFM.Sprint3.Task0.V7.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {

            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.333;
            Assert.AreEqual(res, wait);

        }
    }
}