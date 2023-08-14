using System.Threading.Channels;

namespace ControlStatement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 홀/ 짝 구분
            Console.Write("숫자를 입력해주세요. :");
            int _number = int.Parse(Console.ReadLine());

            if(_number % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }

            // 등급 출력
            int _playerScore = 100;
            string _playerRank = "";

            switch(_playerScore / 10)
            {
                case 10:
                case 9:
                    _playerRank = "Diamond";
                    break;
                case 8:
                    _playerRank = "Platinum";
                    break;
                case 7:
                    _playerRank = "Gold";
                    break;
                case 6:
                    _playerRank = "Silver";
                    break;
                default:
                    _playerRank = "Bronze";
                    break;

            }

            Console.WriteLine(_playerRank);

            // 로그인 프로그램
            string _id = "id";
            string _passWord = "pw";

            Console.Write("아이디를 입력하세요 : ");
            string _inputId = Console.ReadLine();
            Console.Write("비밀번호를 입력하세요. : ");
            string _inputPassword = Console.ReadLine();

            if (_id == _inputId && _passWord == _inputPassword)
            {
                Console.WriteLine("로그인 성공!");
            }
            else
            {
                Console.WriteLine("로그인 실패 !");
            }

            // 알파벳 판별 프로그램
            Console.Write("문자를 입력하세요 : ");
            char _input = Console.ReadLine()[0];

            if ( (_input >= 'a' && _input <='z') || (_input >= 'A' && _input <= 'Z'))
            {
                Console.WriteLine("알파벳입니다.");
            }
            else
            {
                Console.WriteLine("알파벳이 아닙니다.");
            }
        }
    }
}