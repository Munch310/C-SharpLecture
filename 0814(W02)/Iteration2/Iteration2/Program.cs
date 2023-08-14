namespace Iteration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가위 바위 보
            //string[] _choices = { "가위", "바위", "보" };
            //string _playerChoice = "";
            //string _computerChoice = _choices[new Random().Next(0, 3)];

            //while (_playerChoice != _computerChoice)
            //{
            //    Console.Write("가위, 바위, 보 중 하나를 선택하세요 : ");
            //    _playerChoice = Console.ReadLine();

            //    if (_playerChoice == _computerChoice)
            //    {
            //        Console.WriteLine("비겼습니다.");
            //    }
            //    else if (
            //        (_playerChoice == "가위" && _computerChoice == "보") ||
            //        (_playerChoice == "바위" && _computerChoice == "가위") ||
            //        (_playerChoice == "보" && _computerChoice == "바위")
            //        )
            //    {
            //        Console.WriteLine("플레이어 승리!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("컴퓨터 승리!");
            //    }
            //}

            // 숫자 맞추기
            int _targetNumber = new Random().Next(1, 101);
            int _guess = 0;
            int _count = 0;
            Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");

            while (_guess != _targetNumber)
            {
                Console.Write("숫자를 입력하세요! : ");
                _guess = int.Parse(Console.ReadLine());
                _count++;
                if (_guess > _targetNumber)
                {
                    Console.WriteLine("숫자가 더 작습니다!");
                }
                else if(_guess < _targetNumber)
                {
                    Console.WriteLine("숫자가 더 큽니다!");
                }
                else
                {
                    Console.WriteLine("맞췄습니다!" + _count + "회 만에 맞췄습니다.");
                }
            }
        }
    }
}