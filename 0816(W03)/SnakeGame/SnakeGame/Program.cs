namespace SnakeGame
{

    class Program
    {
        static void Main(string[] args)
        {
            Map _m = new Map();
            Food _f = new Food(_m);
            Snake _s = new Snake(_m);


            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo _keyInfo = Console.ReadKey();
                    _s.SnakeKey(_keyInfo.Key);
                }

                Console.Clear();
                _s.Move();
                _m.DrawMap();
                _f.CreateFood();

                // 
                Thread.Sleep(1000 / 144);
            }
        }
    }

    // 음식 클래스
    public class Food
    {
        private Map _map;
        private Random _random;

        public Food(Map map)
        {
            _map = map;
            _random = new Random();
        }

        public void CreateFood()
        {
            int _x, _y;

            if (_random.Next(0,100) < 5) // 5% < n, n으로 확률 조절 가능
            {
                do
                {
                    _x = _random.Next(1, _map._maxMapCol - 1);
                    _y = _random.Next(1, _map._maxMapRow - 1);
                } while (_map.GetCell(_x, _y) != '○');

                _map.SetCell(_x, _y, '★'); // 음식 생성
            }
        }
    }

    public class Snake
    {
        private Map _map;
        private List<(int _col, int _row)> _snakeBody; // 뱀 바디 저장
        private Direction _direction;

        public Snake(Map map)
        {
            _map = map;
            _snakeBody = new List<(int _col, int _row)>();
            _direction = Direction.RIGHT;

            int _snakeInitX = _map._maxMapCol / 2;
            int _snakeInitY = _map._maxMapRow / 2;

            // 초기 길이를 설정
            for (int i = 0; i < 4; i++)
            {
                _snakeBody.Add((_snakeInitX - i, _snakeInitY));
                _map.SetCell(_snakeInitX - i, _snakeInitY, '●');
            }
        }

        public void SnakeKey(ConsoleKey _key)
        {
            switch (_key)
            {
                case ConsoleKey.UpArrow:
                    _direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.DOWN;
                    break;
                case ConsoleKey.LeftArrow:
                    _direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.RIGHT;
                    break;
            }
        }

        public void Move()
        {
            int _currentHeadX = _snakeBody[0]._col;
            int _currentHeadY = _snakeBody[0]._row;
            int _newSnakeHeadX = _currentHeadX;
            int _newSnakeHeadY = _currentHeadY;

            switch (_direction)
            {
                case Direction.UP:
                    _newSnakeHeadX--;
                    break;
                case Direction.DOWN:
                    _newSnakeHeadX++;
                    break;
                case Direction.LEFT:
                    _newSnakeHeadY--;
                    break;
                case Direction.RIGHT:
                    _newSnakeHeadY++;
                    break;
            }
            // 머리 위치 리스트에 추가
            if (_map.GetCell(_newSnakeHeadX, _newSnakeHeadY) == '★')
            {
                _snakeBody.Insert(0, (_newSnakeHeadX, _newSnakeHeadY)); // 뱀 머리 추가
                _map.SetCell(_newSnakeHeadX, _newSnakeHeadY, '●'); // 새로운 머리 위치 설정
            }
            // 자신의 몸에 부딪힐 경우
            else if (_map.GetCell(_newSnakeHeadX, _newSnakeHeadY) == '●')
            {
                Console.WriteLine("뱀이 벽에 닿았습니다! 게임 오버!");
                Environment.Exit(0);
            }
            else
            {
                // 기존 꼬리 위치에 '○' 설정
                int tailX = _snakeBody[_snakeBody.Count - 1]._col;
                int tailY = _snakeBody[_snakeBody.Count - 1]._row;
                _map.SetCell(tailX, tailY, '○'); // 꼬리 위치 비우기
                _snakeBody.RemoveAt(_snakeBody.Count - 1); // 꼬리 제거

                _snakeBody.Insert(0, (_newSnakeHeadX, _newSnakeHeadY)); // 뱀 머리 추가
                _map.SetCell(_newSnakeHeadX, _newSnakeHeadY, '●'); // 새로운 머리 위치 설정
            }
        }
    }

    // 게임 맵
    public class Map
    {
        public int _maxMapCol = 15;
        public int _maxMapRow = 15;

        private char[,] _map;

        public Map()
        {
            // 행열 순서
            _map = new char[_maxMapCol, _maxMapRow];
            InitMap();
        }


        // 프로퍼티를 사용하면 더 좋을듯!
        // 셀에 값 설정
        public void SetCell(int x, int y, char value)
        {
            _map[x, y] = value;
        }

        // 셀의 값 반환
        public char GetCell(int x, int y)
        {
            if (x >= 0 && x < _maxMapCol && y >= 0 && y < _maxMapRow)
            {
                return _map[x, y];
            }
            else
            {
                Console.WriteLine("뱀이 자신의 몸에 부딪혔습니다! 게임 오버!");
                Environment.Exit(0);
                // 화면 바깥으로 나갔을 때 예외 처리
                throw new IndexOutOfRangeException();
            }
        }
        // 맵 초기화 메서드
        public void InitMap()
        {
            for (int x = 0; x < _maxMapCol; x++)
            {
                for (int y = 0; y < _maxMapRow; y++)
                {
                    _map[x, y] = '○';
                }
            }
        }

        // 맵 그리는 메서드
        public void DrawMap()
        {
            for (int x = 0; x < _maxMapCol; x++)
            {
                for (int y = 0; y < _maxMapRow; y++)
                {
                    if (IsBorderCell(x, y))
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write(_map[x, y]);
                    }
                }
                Console.WriteLine();
            }
        }

        // 경계 판별
        private bool IsBorderCell(int x, int y)
        {
            return x == 0 || x == _maxMapCol - 1 || y == 0 || y == _maxMapRow - 1;
        }
    }

    public enum Direction
    {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }
}