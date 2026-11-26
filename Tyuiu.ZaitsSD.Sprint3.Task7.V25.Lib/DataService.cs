using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int Len_List = stopValue - startValue + 1;
            double[] res = new double[Len_List];
            for (int i = 0; i < res.Length; i++)
            {
                int x = startValue + i;
                res[i] = Math.Round(Math.Cos(x) + 4.0 * x / 2 - Math.Sin(x) * 3 * x, 2);
            }
            return res;
        }
    }
}
