namespace Practice_SpaceComplexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int FindMax(int[] arr)
            {
                int max = arr[0];

                for(int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }

            int FindMax2(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isMax = true;

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] > arr[i])
                        {
                            isMax = false;
                            break;
                        }
                    }
                    if (isMax)
                    {
                        return arr[i];
                    }
                }
                return -1;
            }

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            int max = FindMax(arr);
            int max2 = FindMax2(arr);
        }
    }
}