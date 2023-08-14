namespace TicTacToeGame
{
    internal class Program
    {
        static char[] _arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int _player1 = 1;
        static int _choice;
        static int _flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("플레이어 1: X 와 플레이어 2: O");
                Console.WriteLine("\n");

                if (_player1 % 2 == 0)
                {
                    Console.WriteLine("플레이어 2의 차례");
                }
                else
                {
                    Console.WriteLine("플레이어 1의 차례");
                }

                Console.WriteLine("\n");
                Map();

                string _line = Console.ReadLine();
                bool _res = int.TryParse(_line, out _choice);

                if (_res == true)
                {
                    if (_arr[_choice] != 'X' && _arr[_choice] != '0')
                    {
                        if (_player1 % 2 == 0)
                        {
                            _arr[_choice] = 'O';
                        }
                        else
                        {
                            _arr[_choice] = 'X';
                        }

                        _player1++;
                    }
                    else
                    {
                        Console.WriteLine($"죄송합니다. {_choice} 행은 이미 {_arr[_choice]}로 표시되어 있습니다.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                }
                _flag = PlayerWin();
            }
            while (_flag != -1 && _flag != 1);

            if (_flag == 1)
            {
                Console.WriteLine($"플레이어 {(_player1 % 2) + 1}이(가) 이겼습니다.");
            }
            else
            {
                Console.WriteLine("무승부");
            }
            Console.ReadLine();
        }

        static void Map()
        {
            // 맵 생성
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[1]}  |  {_arr[2]}  |  {_arr[3]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[4]}  |  {_arr[5]}  |  {_arr[6]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[7]}  |  {_arr[8]}  |  {_arr[9]}  ");
        }

        static int PlayerWin()
        {
            if (_arr[1] == _arr[2] && _arr[2] == _arr[3])
            {
                return 1;
            }
            if (_arr[4] == _arr[5] && _arr[5] == _arr[6])
            {
                return 1;
            }
            if (_arr[7] == _arr[8] && _arr[8] == _arr[9])
            {
                return 1;
            }

            else if (_arr[1] == _arr[4] && _arr[4] == _arr[7])
            {
                return 1;
            }
            else if (_arr[2] == _arr[5] && _arr[5] == _arr[8])
            {
                return 1;
            }
            else if (_arr[3] == _arr[6] && _arr[6] == _arr[9])
            {
                return 1;
            }

            else if (_arr[1] == _arr[5] && _arr[5] == _arr[9])
            {
                return 1;
            }
            else if (_arr[3] == _arr[5] && _arr[5] == _arr[7])
            {
                return 1;
            }
            else if (_arr[1] != '1' && _arr[2] != '2' && _arr[3] != '3' && _arr[4] != '4' && _arr[5] != '5' && _arr[6] != '6' && _arr[7] != '7' && _arr[8] != '8' && _arr[9] != '9')
            {
                return -1;
            }
            else { return 0; }
        }
    }
}