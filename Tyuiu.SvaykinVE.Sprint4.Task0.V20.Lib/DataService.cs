using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SvaykinVE.Sprint4.Task0.V20.Lib
{
    public class DataService : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int res = 1;
            for (int i = 1; i < 10; i+=2)
                res *= array[i];
            return res;
        }
    }
}
