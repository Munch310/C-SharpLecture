namespace W01HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-1 사용자로부터 입력 받기
            Console.Write("이름을 입력하세요 : ");
            string _name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            string _age = Console.ReadLine();

            string _result = $"안녕하세요, {_name}! 당신은 {_age} 세 이군요.";
            Console.WriteLine(_result);

            // 1-2 간단한 사칙연산 계산기 만들기
            Console.WriteLine("사칙연산 계산기");
            Console.Write("첫번째 수를 입력하세요. : ");
            string _num1 = Console.ReadLine();
            Console.Write("두번째 수를 입력하세요. : ");
            string _num2 = Console.ReadLine();

            int _intNum1 = int.Parse(_num1);
            int _intNum2 = int.Parse(_num2);
            float _floatNum1 = float.Parse(_num1);
            float _floatNum2 = float.Parse(_num2);

            Console.WriteLine("더하기 : " + (_intNum1 + _intNum2));
            Console.WriteLine("빼기 : " + (_intNum1 - _intNum2));
            Console.WriteLine("곱하기 : " + (_intNum1 * _intNum2));
            Console.WriteLine("나누기 : " + (_floatNum1 / _floatNum2));

            // 1-3 온도 변환기 만들기
            Console.WriteLine("온도 변환기");
            Console.Write("섭씨 온도를 입력하세요. : ");
            float _celcius = float.Parse(Console.ReadLine());
            float _fahrenheit = (_celcius * 9 / 5) + 32;

            Console.WriteLine("변환된 화씨 온도 : " + _fahrenheit);

            // 1-4 BMI 계산기 만들기
            Console.WriteLine("BMI 계산기");

            Console.Write("당신의 키를 입력해주세요. (소숫점 2자리 까지 입력해주세요.) (단위 : cm) : ");
            float _height = float.Parse(Console.ReadLine());
            Console.Write("당신의 몸무게를 입력해주세요. (소숫점 2자리 까지 입력해주세요.) (단위 : kg) :");
            float _weight = float.Parse(Console.ReadLine());

            float _bmi = _weight / (_height / 100* 2);
            string _bmiResult = _bmi.ToString("F2");
            Console.WriteLine($"당신의 BMI 수치는 {_bmiResult} 입니다.");


        }
    }
}