namespace Practice_Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                
                for(int j = i + 1; j < arr.Length; j++)
                {
                    // 가장 작은 값을 찾아서 위치를 저장.
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // swap
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            foreach (int num in arr)
            {
                Console.Write(num);
            }
            
        }
    }
}