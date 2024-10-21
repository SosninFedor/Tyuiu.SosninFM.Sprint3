
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(value, i) + 1) * (Math.Cos(i)));
            }

            return Math.Round(sumSeries, 3);

        }
    }
}
