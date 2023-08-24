namespace Practice_Lambda_Deligate_Function
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine("message");
        }
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add; // 첫번쨰는 input 1, 두번째는 input 2, 마지막은 result
            int result = addFunc(3, 5);
            Console.WriteLine("결과 :" + result);

            Action<string> printAction = PrintMessage; // 반환값 없음!
            printAction("Hello, World!");
        }
    }
}