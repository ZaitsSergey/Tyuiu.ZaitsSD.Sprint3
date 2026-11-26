using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task6.V10.Lib
{
    public class DataService : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 13; j <= i; j++)
                {
                    if (i % j == 0) res += j;
                }
            }
            return res;
        }
    }
}
