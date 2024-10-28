
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {   
            double sumSeries = 0;
            double res = 0;
            int s = startValue;

            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value, s) + (5 / (s + 4) * (Math.Sin(value))) );
                res += sumSeries;
                sumSeries++; 
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
