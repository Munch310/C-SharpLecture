namespace OperatorExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("산술 연산자, 포맷 입력 차이");
            int num1 = 20, num2 = 10;
            Console.WriteLine("{0} + {1}", num1, num2); // stirng형태임.
            Console.WriteLine("{0} - {1}", num1, num2);
            Console.WriteLine("{0} / {1}", num1, num2);
            Console.WriteLine("{0} * {1}", num1, num2);
            Console.WriteLine("{0} % {1}", num1, num2);

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 % num2);
            Console.WriteLine(" "); // 빈줄

            Console.WriteLine("관계 연산자");
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(" "); // 빈줄

            Console.WriteLine("논리 연산자");
            int num3 = 15;
            // 0<= num3 <=20
            Console.WriteLine(0 <= num3 && num3 <= 20); // 0과 20사이에 포함되면! True
            Console.WriteLine(0 > num3 || num3 > 20);  // 0과 20 사이에 포함되지 않으면! True

            Console.WriteLine(!(0 <= num3 && num3 <= 20)); // == or과 동일한 코드
            Console.WriteLine(" "); // 빈줄


            Console.WriteLine("비트 연산자");
            int a = 0b1100;
            int b = 0b1010;

            int and = a & b;
            int or = a | b;
            int xor = a ^ b;

            int c = 0b1011;
            int leftShift = c << 2;
            int rightShift = c >> 1;

            int d = 0b1100;
            int bit3 = (d >> 2) & 0b1;
            d |= 0b1000; // 0b1100 | 0b1100 = 0b1100(22)
            Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", and, or, xor, leftShift, rightShift, bit3);


        }
    }
}