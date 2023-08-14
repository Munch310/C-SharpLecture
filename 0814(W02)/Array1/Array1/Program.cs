using System.Runtime.InteropServices;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 학생들의 평균 성적 구하기
            //int[] _scores = new int[5];
            //for(int i = 0; i < _scores.Length; i++)
            //{
            //    Console.Write("학생 " + (i + 1) + " 의 성적을 입력하세요 : ");
            //    _scores[i] = int.Parse(Console.ReadLine());
            //}

            //int _sum = 0;
            //for(int i = 0;i < _scores.Length ; i++)
            //{
            //    _sum += _scores[i];
            //}

            //double _average = (double) _sum / _scores.Length;
            //Console.WriteLine("성적 평균은 " + _average + " 입니다.");

            // 4 배열을 활용한 숫자 맞추기 게임

            Random _random = new Random();
            int[] _numbers = new int[3];

            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = _random.Next(1, 10);
            }

            int _attempt = 0; // 시도 횟수 초기화
            while (true)
            {
                Console.WriteLine("3개의 숫자를 입력하세요.");
                int[] _guesses = new int[3];
                for (int i = 0; i < _guesses.Length; i++)
                {
                    _guesses[i] = int.Parse(Console.ReadLine());
                }

                int _correct = 0;

                for (int i = 0; i < _numbers.Length; i++)
                {
                    for (int j = 0; j < _guesses.Length; j++)
                    {
                        if (_numbers[i] == _guesses[j])
                        {
                            _correct++;
                            break;
                        }
                    }
                }

                _attempt++;
                Console.WriteLine("시도 #" + _attempt + " : " + _correct + "개의 숫자를 맞추셨습니다.");

                if (_correct == 3)
                {
                    Console.WriteLine("축하합니다. 모든 숫자를 맞추셨습니다.");
                    break;
                }
            }
        }
    }
}