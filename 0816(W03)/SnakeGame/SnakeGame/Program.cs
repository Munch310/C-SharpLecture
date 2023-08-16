namespace SnakeGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // 뱀의 초기 위치와 방향을 설정하고, 그립니다.
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); // 인자가 3개.
            snake.Draw(); // 뱀을 형상화

            // 음식의 위치를 무작위로 생성하고, 그립니다.
            FoodCreator foodCreator = new FoodCreator(80, 20, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // 게임 루프: 이 루프는 게임이 끝날 때까지 계속 실행됩니다.
            while (true)
            {
                // 키 입력이 있는 경우에만 방향을 변경합니다.
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo _keyInfo = Console.ReadKey();
                    switch (_keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snake.snakeDirection(Direction.UP);
                            break;
                        case ConsoleKey.DownArrow:
                            snake.snakeDirection(Direction.DOWN);
                            break;
                        case ConsoleKey.RightArrow:
                            snake.snakeDirection(Direction.RIGHT);
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.snakeDirection(Direction.LEFT);
                            break;
                        default:
                            break;
                    }
                }
                snake.Move(food);

                // 뱀이 이동하고, 음식을 먹었는지, 벽이나 자신의 몸에 부딪혔는지 등을 확인하고 처리하는 로직을 작성하세요.
                // 이동, 음식 먹기, 충돌 처리 등의 로직을 완성하세요.

                Thread.Sleep(100); // 게임 속도 조절 (이 값을 변경하면 게임의 속도가 바뀝니다)

                // 뱀의 상태를 출력합니다 (예: 현재 길이, 먹은 음식의 수 등)
            }
        }
    }

    public class Snake
    {
        private List<Point> _snakeBody; // Generic, Point의 객체를 LIst로 관리할 수 있음.
        private Direction _direction;


        public Snake(Point _initPosition, int _initLength, Direction _initDirection)
        {
            _snakeBody = new List<Point>();
            _direction = _initDirection;

            // 길이는 0부터 
            for (int i = 0; i < _initLength; i++)
            {
                int _newX = _initPosition.x - i;
                int _newY = _initPosition.y;
                Point _plusBody = new Point(_newX, _newY, '*');
                _snakeBody.Add(_plusBody);
            }
        }
        public void Draw()
        {
            foreach (Point _body in _snakeBody)
            {
                Console.SetCursorPosition(_body.x, _body.y);
                Console.Write(_body.sym);
            }
        }

        public void Move(Point food)
        {
            Point _snakeHead = _snakeBody.First();
            Point _newHead = new Point(_snakeHead.x, _snakeHead.y, _snakeHead.sym);

            switch (_direction)
            {
                case Direction.UP:
                    _newHead.y--;
                    break;
                case Direction.DOWN:
                    _newHead.y++;
                    break;
                case Direction.RIGHT:
                    _newHead.x++;
                    break;
                case Direction.LEFT:
                    _newHead.x--;
                    break;
                default:
                    break;
            }

            _snakeBody.Insert(0, _newHead);


            Point _tail = _snakeBody.Last();
            _tail.Clear();
            _snakeBody.Remove(_tail);

            Draw();
        }

        public void snakeDirection(Direction _newDirection)
        {
            _direction = _newDirection;
        }

    }

    public class FoodCreator
    {
        private int _foodPosX;
        private int _foodPosY;
        private char _foodSym;
        public FoodCreator(int foodPosX, int foodPosY, char foodSym)
        {
            _foodPosX = foodPosX;
            _foodPosY = foodPosY;
            _foodSym = foodSym;
        }

        public Point CreateFood()
        {
            return new Point(_foodPosX, _foodPosY, _foodSym);
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public char sym { get; set; }

        // Point 클래스 생성자
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // 점을 그리는 메서드
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        // 점을 지우는 메서드
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        // 두 점이 같은지 비교하는 메서드
        public bool IsHit(Point p)
        {
            return p.x == x && p.y == y;
        }

        public Point createFood(int _maxX, int _maxY)
        {
            Random random = new Random();
            int _randomX = random.Next(1, _maxX); // 랜덤한 X 좌표 생성 (범위 내에서)
            int _randomY = random.Next(1, _maxY); // 랜덤한 Y 좌표 생성 (범위 내에서)

            return new Point(_randomX, _randomY, sym); // 랜덤한 위치에 음식 생성
        }
    }
    // 방향을 표현하는 열거형입니다.
    public enum Direction // enumeration 열거형, 특정한 방향을 C#
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
}