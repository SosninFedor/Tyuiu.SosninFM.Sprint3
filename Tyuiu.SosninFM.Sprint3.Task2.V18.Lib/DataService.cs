
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            
            double MultSeries = 1;
            do
            {
                MultSeries = MultSeries + ((Math.Cos(value)) + (Math.Pow(startValue / 8), 3));
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(MultSeries, 3);


        }
    }
}
