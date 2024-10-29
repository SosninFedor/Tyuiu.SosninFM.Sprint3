
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SosninFM.Sprint3.Task3.V1.Lib;

namespace Tyuiu.SosninFM.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
