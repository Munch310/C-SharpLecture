namespace SnakeGame
{
    internal class Program
    {
        static void Snake()
        {
            ConsoleKeyInfo _key;

            do
            {
                _key = Console.ReadKey(); // 입력한 키를 받습니다.
                switch (_key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽");
                        break;
                }

            } while (_key.Key != ConsoleKey.Escape);
        }

        static void FoodCreator()
        {
            int _food = new Random().Next(); // 배열
        }
        static void Main(string[] args)
        {
            Snake();
        }
    }
}