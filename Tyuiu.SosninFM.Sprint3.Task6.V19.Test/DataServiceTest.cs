
using Tyuiu.SosninFM.Sprint3.Task6.V19.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int endValue = 15;

            int res = ds.GetSumTheDivisors(startValue, endValue);

            int wait = 16;

            Assert.AreEqual(res, wait);



        }
    }
}