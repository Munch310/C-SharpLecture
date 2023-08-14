namespace ChoiceNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random _random = new Random();
            int _numberToGuess = _random.Next(1, 101);
            int _num = 0;
            int _tryCount = 0;


            Console.WriteLine("숫자 맞추기 게임을 시작합니다. 1에서 100까지 숫자 중 하나를 맞춰보세요.");
            

            while (_num != _numberToGuess)
            {
                Console.Write("숫자를 입력하세요 : ");
                _num = int.Parse(Console.ReadLine());
                _tryCount++;

                if (_num > _numberToGuess)
                {
                    Console.WriteLine("너무 큽니다!");
                }
                else if(_num < _numberToGuess)
                {
                    Console.WriteLine("너무 작습니다!");
                }
                else
                {
                    Console.WriteLine("축하합니다!" + _tryCount + "번 만에 숫자를 맞추었습니다.");
                }
            }
        }
    }
}