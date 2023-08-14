using System.Data;

namespace MethodOverloading1
{
    internal class Program
    {
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static float AddNumbers(float a, float b)
        {
            return a + b;
        }

        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int _sum1 = AddNumbers(10, 20);
            float _sum2 = AddNumbers(10.5f, 21.5f);
            int _sum3 = AddNumbers(10, 20, 30);

        }
    }
}