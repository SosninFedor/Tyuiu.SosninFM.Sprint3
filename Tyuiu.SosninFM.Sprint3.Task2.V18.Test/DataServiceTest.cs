
using Tyuiu.SosninFM.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 3.589;
            Assert.AreEqual(res, wait);


        }
    }
}