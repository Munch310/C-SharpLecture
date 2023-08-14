namespace Iteration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for
            //for (int j = 0; j< 10; j++)
            //{
            //    Console.WriteLine(j);
            //}

            // while
            //int _count = 0;
            //while(_count < 20)
            //{
            //    Console.WriteLine(_count);
            //    _count++;
            //}

            // 구구단
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        Console.Write(j + " x " + i + " = " + (i*j) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // break, continue
            //for(int i = 0; i<= 10; i++)
            //{
            //    if (i%3 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);

            //    if(i == 7)
            //    {
            //        break;
            //    }
            //}

            // break, continue Example

            int _sum = 0;

            while (true)  // 무한 루프 , for(;;)
            {
                Console.Write("숫자를 입력하세요 : ");
                int _input = int.Parse(Console.ReadLine());

                if (_input == 0)
                {
                    Console.WriteLine("프로그램 종료.");
                    break;
                }

                if (_input <= 0)
                {
                    Console.WriteLine("음수는 무시한다.");
                    break;
                }

                _sum += _input;
                Console.WriteLine(_sum);
            }

            Console.WriteLine("합계 : " + _sum);

        }
    }
}