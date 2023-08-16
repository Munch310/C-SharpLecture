namespace OutRefExam
{
    internal class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder) // 여기서 out 인자는 Main의 변수에 영향을 끼친다. 항상 값을 채워줘야 한다.
        {
            quotient = a / b;
            remainder = a % b;

        }

        static void Swap(ref int a, ref int b) // out 과 다르게 값을 채워주지 않아도 동작은 한다.
        {
            int temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            int quotient, remainder;
            Divide(7,3, out quotient, out remainder);
            Console.WriteLine($"{quotient}, {remainder}");

            int x = 1, y = 2;
            Swap(ref x, ref y); // 값이 변할 수도 있고, 변하지 않을 수도 있다.
            Console.WriteLine($"{x}, {y}");
        }
    }
}