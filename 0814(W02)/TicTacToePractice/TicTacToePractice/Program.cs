namespace TicTacToePractice
{
    internal class Program
    {
        static char[] _arr = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // char -> 단 하나의 문자이기 때문에!
        static int _goal; // 게임 승패여부 1 = 승리, 0 = 무승부, -1 = 패배
        static int _choice;
        static int _player1 = 1;

        static void Main(string[] args)
        {
            do
            {
                // 게임 시작
                Console.Clear();
                Console.WriteLine("Tic Tac Toe Game!");
                Console.WriteLine("Player 1 : X, Player 2 : O");
                Console.WriteLine("\n");

                // 플레이어 순서 출력
                if (_player1 % 2 == 0) // _player1 변수가 짝수일 때는 Player 2의 차례, 홀수일 때는 Player 1의 차례
                {
                    Console.WriteLine("Player 2's turn ");
                }
                else
                {
                    Console.WriteLine("Player 1's turn");
                }

                Console.WriteLine("\n");
                Map(); // 게임 맵 출력

                string _input = Console.ReadLine();
                bool _res = int.TryParse(_input, out _choice); // 사용자 입력을 정수로 변환

                if (_res = true) // 사용자 입력이 성공적으로 정수로 변환되었을 때
                {
                    if (_arr[_choice] != 'X' && _arr[_choice] != 'O') // 선택한 위치가 'X'나 'O'로 이미 마킹되지 않았을 때
                    {
                        if (_player1 % 2 == 0) // 플레이어 2의 차례일 때
                        {
                            _arr[_choice] = 'O';
                        }
                        else // 플레이어 1의 차례일 때
                        {
                            _arr[_choice] = 'X';
                        }

                        _player1++;  // 플레이어 순서 변경
                    }
                    else  // 선택한 위치가 이미 마킹된 경우
                    {
                        Console.WriteLine($"Sorry, the {_choice} array is already marked {_arr[_choice]}. Please try again.");
                        Console.ReadLine();
                    }
                }
                else // 사용자 입력이 정수로 변환되지 않은 경우
                {
                    Console.WriteLine($"Please enter only numbers from 1 to 9.");
                }
                _goal = GameLogic(); // 게임 로직 실행 및 결과 받아옴
            } 
            while (_goal != -1 && _goal != 1); // 게임이 종료 상태가 아닐 때까지 반복

            if (_goal == 1) // 게임 승리 상태인 경우
            {
                Console.WriteLine($"Player {(_player1 % 2) * 1} is Win!");
            }
            else // 무승부 상태인 경우
            {
                Console.WriteLine("Draw!");
            }
            
            Console.ReadLine(); // 사용자 입력 기다림
        }

        static int GameLogic()
        {
            // 가로
            if (_arr[1] == _arr[2] && _arr[2] == _arr[3]) // 123
            {
                return 1;
            }
            if (_arr[4] == _arr[5] && _arr[5] == _arr[6]) // 456
            {
                return 1;
            }
            if (_arr[7] == _arr[8] && _arr[8] == _arr[9]) // 789
            {
                return 1;
            }

            // 세로
            else if (_arr[1] == _arr[4] && _arr[4] == _arr[7]) // 147
            {
                return 1;
            }
            else if (_arr[2] == _arr[5] && _arr[5] == _arr[8]) // 258
            {
                return 1;
            }
            else if (_arr[3] == _arr[6] && _arr[6] == _arr[9]) // 369
            {
                return 1;
            }

            else if (_arr[1] == _arr[5] && _arr[5] == _arr[9]) // 159
            {
                return 1;
            }
            else if (_arr[3] == _arr[5] && _arr[5] == _arr[7]) // 357
            {
                return 1;
            }
            // 모든 칸이 해당된 배열의 값과 다르면 무승부 ! -> O와 X로 모두 채워짐.
            else if (_arr[1] != '1' && _arr[2] != '2' && _arr[3] != '3' && _arr[4] != '4' && _arr[5] != '5' && _arr[6] != '6' && _arr[7] != '7' && _arr[8] != '8' && _arr[9] != '9')
            {
                return -1;
            }
            else { return 0; }


        }

        static void Map()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[0]}  |  {_arr[1]}  |  {_arr[2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[3]}  |  {_arr[4]}  |  {_arr[5]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {_arr[6]}  |  {_arr[7]}  |  {_arr[8]}  ");
            Console.WriteLine("     |     |     ");
        }
    }
}