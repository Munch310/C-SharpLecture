namespace Practice_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum(int n)
            {
                int sum = 0;
                for (int i= 0; i < n; i++)
                {
                    sum += i;
                }
                return sum;
            }
            Console.WriteLine(sum(2));
            PrintPairs(3);


        }

        static public void PrintPairs(int n)
        {
            for(int i= 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }
        }

        int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + (n - 2);
            }
        }
    }
}