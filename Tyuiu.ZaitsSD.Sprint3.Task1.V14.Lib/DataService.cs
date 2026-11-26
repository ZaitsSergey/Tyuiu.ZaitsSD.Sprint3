using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            while (startValue <= stopValue)
            {
                res += (Math.Pow(value, startValue) + 1.0 / (startValue + 1)) * Math.Cos(value);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
