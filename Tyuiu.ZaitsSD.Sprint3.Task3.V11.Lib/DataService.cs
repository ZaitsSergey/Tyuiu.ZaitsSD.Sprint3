using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaitsSD.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char symbol in value)
            {
                if (symbol == replaceable) res += replacement;
                else res += symbol;
            }
            return res;
        }
    }
}
