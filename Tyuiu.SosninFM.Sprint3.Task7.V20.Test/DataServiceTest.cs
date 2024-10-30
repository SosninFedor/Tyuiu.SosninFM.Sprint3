
using Tyuiu.SosninFM.Sprint3.Task7.V20.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 17.27;
            valueWaitArray[1] = 14.08;
            valueWaitArray[2] = 10.27;
            valueWaitArray[3] = 6.65;
            valueWaitArray[4] = 3.87;
            valueWaitArray[5] = 2.00;
            valueWaitArray[6] = -0.74;
            valueWaitArray[7] = -3.71;
            valueWaitArray[8] = -7.59;
            valueWaitArray[9] = -11.55;
            valueWaitArray[10] = -14.74;

            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(res, valueWaitArray);


        }
    }
}