
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {   
            double sumSeries = 0;
            double p; 
            

            while (startValue <= stopValue)
            {
                p = Convert.ToDouble(startValue);
                sumSeries += (Math.Pow(value, p) + (5 / (p + 4))) * (Math.Sin(value));
                startValue++; 
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
