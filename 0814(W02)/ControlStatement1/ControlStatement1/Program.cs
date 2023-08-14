using System.Threading.Channels;

namespace ControlStatement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if 실습
            int _playerScore = 80;

            if(_playerScore >= 70)
            {
                Console.WriteLine("플레이어의 점수는 70점 이상입니다. 합격입니다!");
            }
            Console.WriteLine("프로그램이 종료됩니다.");

            Console.WriteLine(" ");

            // if else 실습
            int _itemCount = 5;
            string _itemName = "HP 포션";

            if(_itemCount > 0)
            {
                Console.WriteLine($"보유한 {_itemName}의 수량: {_itemCount}");
            }
            else
            {
                Console.WriteLine($"보유한 {_itemName}이 없습니다.");
            }

            // else if 실습
            int _score = 100;
            string _playerRank = "";
            if (_score >= 90)
            {
                _playerRank = "Diamond";
            }
            else if (_score >= 80)
            {
                _playerRank = "Platinum";
            }
            else if (_score >= 70) 
            {
                _playerRank = "Gold";
            }
            
            else if (_score >= 60)
            {
                _playerRank = "Silver";
            }
            else
            {
                _playerRank = "Bronze";
            }

            Console.WriteLine($"플레이어의 등급은 {_playerRank} 입니다.");

            Console.WriteLine(" ");

            // switch 실습
            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("1. 전사 / 2. 마법사 / 3. 궁수");
            Console.Write("직업을 선택하세요. :");
            string _job = Console.ReadLine();
            
            switch( _job ) // _job이 스트링이기 때문에 Case를 string으로 준다.
            {
                case "1":
                    Console.WriteLine("전사를 선택하셨습니다.") ;
                    break;

                case "2":
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    break;
                case "3":
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;
                default: // 생략 가능
                    Console.WriteLine("잘못된 값입니다.");
                    break;
            }

            Console.WriteLine("게임을 종료합니다.");

            // 삼항 연산자 실습
            int _currentExp = 1200;
            int _requiredExp = 2000;

            // 삼항 연산자
            string _result = (_currentExp >= _requiredExp) ? "레벨업 가능" : "레벨업 불가능";
            Console.WriteLine(_result);

            // if else
            if (_currentExp>= _requiredExp)
            {
                Console.WriteLine("레벨업 가능");
            }
            else
            {
                Console.WriteLine("레벨업 불가능");
            }
        }
    }
}