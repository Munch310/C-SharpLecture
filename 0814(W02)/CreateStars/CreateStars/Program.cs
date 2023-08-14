namespace CreateStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 오른쪽 기울어진
            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = i; j<6; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}


            // 역직각
            //for (int i = 0; i < 5; i++)
            //{
            //    for(int j = i; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            // 피라미드
            int i, j, k, l;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < (5 - i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}