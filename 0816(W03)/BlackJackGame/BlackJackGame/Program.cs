using System.Diagnostics.CodeAnalysis;
using static BlackJackGame.Program;

namespace BlackJackGame
{
    internal class Program
    {
        public int _player = 0;
        public int _dealer = 1;
        public enum Suit {Spades, Hearts, Diamonds, Clubs }
        public enum Number { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten = 10, Jack=10, Queen=10, King=10, Ace=11 }
        static void Main(string[] args)
        {
            Hand _h = new Hand();
            _h.StartGame();
        }

        public class Deck
        {
            private List<(Number, Suit)> _deck = new List<(Number, Suit)>();

            public Deck()
            {
                Initdeck();
            }
            
            // Fisher - Yates
            public void DeckShuffle(List<(Number, Suit)> _deck)
            {
                Random _random = new Random();
                int _n = _deck.Count; // 현재 덱의 개수
                while (_n > 1) // 한 장 남을 때 까지
                {
                    _n--; // 현재 처리할 아이템 인덱스
                    int _k = _random.Next(_n + 1); // 현재 덱의 개수 보다 작은 숫자, _k에 할당
                    (Number, Suit) _temp = _deck[_k]; 
                    _deck[_k] = _deck[_n];
                    _deck[_n] = _temp;
                }
            }

            public void Initdeck()
            {
                foreach (Number _n in Enum.GetValues(typeof(Number)))
                {
                    foreach (Suit _s in Enum.GetValues(typeof(Suit)))
                    {
                        _deck.Add((_n, _s));
                    }
                }
                DeckShuffle(_deck);


                //// 덱 출력 
                //foreach (var _card in _deck)
                //{
                //    Console.WriteLine($"Number:{_card.Item1}, Suit:{_card.Item2}");
                //}
            }

            public (Number, Suit) DrawCard()
            {
                if (_deck.Count > 0)
                {
                    (Number, Suit) card = _deck[0];
                    _deck.RemoveAt(0);
                    return card;
                }
                else
                {
                    // 오류 처리
                    Console.WriteLine("덱에 카드가 없습니다.");
                    return default((Number, Suit)); //
                }
            }
        }

        public class Hand
        {
            protected List<(Number, Suit)> _playerHand = new List<(Number, Suit)>();
            protected List<(Number, Suit)> _dealerHand = new List<(Number, Suit)>();

            public int HandSum(List<(Number, Suit)> hand)
            {
                int sum = 0;
                foreach (var card in hand)
                {
                    sum += (int)card.Item1;
                }
                return sum;
            }

            public void DesplayCards(List<Tuple<int, string>> hand)
            {
            }

            public void Bust()
            {
                
            }

            public void StartGame()
            {
                Deck _d = new Deck();

                _d.Initdeck();

                for (int i = 0; i < 2; i++)
                {
                    _playerHand.Add(_d.DrawCard());
                    _dealerHand.Add(_d.DrawCard());
                }
                Console.WriteLine("플레이어 카드");
                foreach(var _pCard in _playerHand)
                {
                    Console.WriteLine($"Number : {_pCard.Item1}, Suit : {_pCard.Item2}");
                    
                }

                Console.WriteLine("딜러 카드");
                foreach (var _dCard in _dealerHand)
                {
                    Console.WriteLine($"Number : {_dCard.Item1}, Suit : {_dCard.Item2}");
                }
                int _playerSum = HandSum(_playerHand);
                int _dealerSum = HandSum(_dealerHand);
                if (_playerSum > 21)
                {
                    Console.WriteLine("플레이어 버스트! 딜러 승리");
                }
                else if (_dealerSum > 21)
                {
                    Console.WriteLine("딜러 버스트! 플레이어 승리");
                }
                else if(_playerSum < 21 || _dealerSum < 17)
                {
                    Console.WriteLine("Hit");
                    // 키보드 입력받아서 카드를 한 장 더 뽑을지 정의해야함.
                    _playerHand.Add(_d.DrawCard());
                    _dealerHand.Add(_d.DrawCard());

                    Console.WriteLine("플레이어 카드");
                    foreach (var _pCard in _playerHand)
                    {
                        Console.WriteLine($"Number : {_pCard.Item1}, Suit : {_pCard.Item2}");
                    }

                    Console.WriteLine("딜러 카드");
                    foreach (var _dCard in _dealerHand)
                    {
                        Console.WriteLine($"Number : {_dCard.Item1}, Suit : {_dCard.Item2}");
                    }

                    int _newDealerSum = HandSum(_dealerHand);
                    int _newPlyaerSum = HandSum(_playerHand);
                    if (_newPlyaerSum > 21)
                    {
                        Console.WriteLine("플레이어 버스트! 딜러 승리");
                    }
                    else if(_newDealerSum > 21)
                    {
                        Console.WriteLine("딜러 버스트! 플레이어 승리");
                    }



                }
            }
        }
    }
}