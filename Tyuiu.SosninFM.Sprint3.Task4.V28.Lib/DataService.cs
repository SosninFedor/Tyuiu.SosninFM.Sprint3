
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SosninFM.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            // На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(cos(x)+sin(x))/x
            //При х = 0 пропустить значение. Полученные значения суммировать.

            double res = 0;
            for (int x = startValue; x < stopValue; x++)
            {
                if (x == 0)
                {
                    break;

                }
                else
                {
                    res = res + (Math.Cos(x) + Math.Sin(x) / x);
                }
            }
            return Math.Round(res,3);



        }
    }
}
