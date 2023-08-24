namespace Practice_Delegate
{
    internal class Program
    {
        delegate void MyuDelegate(string message);

        static void Method1(string message)
        {
            Console.WriteLine("Method1 : " + message);
        }

        static void Method2(string message) 
        {
            Console.WriteLine("Method2 : " + message);
        }
        static void Main(string[] args)
        {

            MyuDelegate myuDelegate = Method1;
            myuDelegate += Method2;

            myuDelegate("Hello");
        }
    }
}