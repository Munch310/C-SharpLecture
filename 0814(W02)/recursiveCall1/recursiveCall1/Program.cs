namespace recursiveCall1
{
    internal class Program
    {
        static void CountDown(int n)
        {
            if (n<= 0)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine(n);
                CountDown(n-1); // 자기 자신 호출
            }
        }
        static void Main(string[] args)
        {
            CountDown(5);
        }
    }
}