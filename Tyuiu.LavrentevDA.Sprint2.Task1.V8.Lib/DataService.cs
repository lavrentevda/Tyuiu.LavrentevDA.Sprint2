using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LavrentevDA.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b); 

            res[1] = (a != c) & (b > d); 

            res[2] = (c < b) || (d >= a); 

            res[3] = !(a == 15) | (b <= c); 

            res[4] = (d > 300) && (a == 15); 

            res[5] = (b < a) ^ (c > b);


            return res;
        }
    }
}
