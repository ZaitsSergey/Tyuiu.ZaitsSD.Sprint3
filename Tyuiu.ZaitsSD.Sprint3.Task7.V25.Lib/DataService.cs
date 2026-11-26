using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int Len_List = stopValue - startValue + 1;
            int Element_Massiv = 0;
            double[] res = new double[Len_List];
            for (int i = startValue; i <= stopValue; i++)
            {
                res[Element_Massiv] = Math.Round(Math.Cos(i) + 4 * i / 2 - (Math.Sin(i) * 3 * i),2);
                Element_Massiv ++;
            }
            return res;
        }
    }
}
