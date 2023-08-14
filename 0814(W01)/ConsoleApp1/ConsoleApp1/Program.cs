namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 줄 바꿈
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My Name is Moon");
            Console.WriteLine("C#");
            Console.WriteLine("뭉크");

            Console.WriteLine("\' \' \" ");

            Console.WriteLine(10);
            Console.WriteLine(3.141592);
            Console.WriteLine(3 + 3);

            // 줄 바꿈 X
            Console.Write("Hello! ");
            Console.Write("We are Learning ");
            Console.WriteLine("at TeamSparta");

            // 이스케이프 시퀀스(Escape Sequence)
            Console.WriteLine("Hello\nWorld"); // 줄 바꿈
            Console.WriteLine("Name\tAge"); // 탭 삽입(빈공간)
            Console.WriteLine("Munch\t26");
            Console.WriteLine("Munch\b33"); // 백 스페이스, Munc33 (h가 사라짐)

            Console.WriteLine("We learn \"C# Programming\"");
            Console.WriteLine("He said, \'Hello\' to me");
            Console.WriteLine("C:\\MyDocuments\\Project\\");


            // 주석

            // 변수 a 선언
            int a;

            /*
            여러 줄 주석입니다.
            여러 줄 작성 가능합니다. 
             */

            // 변수 a 값 할당
            a = 10;
        }
    }
}