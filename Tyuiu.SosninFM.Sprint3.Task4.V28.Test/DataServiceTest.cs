
using Tyuiu.SosninFM.Sprint3.Task4.V28.Lib;


namespace Tyuiu.SosninFM.Sprint3.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -0.274;
            Assert.AreEqual(res, wait);

        }
    }
}