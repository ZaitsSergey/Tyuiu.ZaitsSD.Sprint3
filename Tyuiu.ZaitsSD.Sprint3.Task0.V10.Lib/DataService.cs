using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                res *= Math.Pow(300 / (i + Math.Pow(value, i)), i);
            }
            return Math.Round(res, 3);
        }
    }
}
