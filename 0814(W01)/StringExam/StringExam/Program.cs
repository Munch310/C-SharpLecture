namespace StringExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _str1 = "Hello, World!";
            string _str2 = new string('h', 5);

            string _str3 = _str1 + " " + _str2; // _str1 + " " 로 문자열 1, (_str1 + " ") + _str2로 문자열 2번 만들기 때문에 추천 x
            Console.WriteLine(_str3);

            string[] _str4 = _str1.Split(','); // Sprit(' ') 안의 문자로 문자열을 나눈다.
            Console.WriteLine(_str4[0]);
            Console.WriteLine(_str4[1]);

            int _index = _str1.IndexOf("World!");
            Console.WriteLine(_index); // 단어가 시작되는 인덱스는 7번임

            string _newStr = _str1.Replace("World", "Universe");
            Console.WriteLine(_newStr);
            Console.WriteLine(_str1);

            string _str5 = "123";
            int _num = int.Parse(_str5);
            Console.WriteLine(_num);

            _num += 10;

            Console.WriteLine(_num.ToString());

            Console.WriteLine(_str1 == _str2);
            Console.WriteLine(string.Compare(_str1,_str2)); // 소문자가 대문자보다 값이 크다. _str2의 소문자 값이 더 크다.

            string _name = "John";
            int _age = 30;
            string _message = string.Format("My name is {0} and I'm {1} years old", _name, _age);
            Console.WriteLine(_message);

            _message = $"My name is {_name} and I'm {_age} years old";
            Console.WriteLine(_message);
        }
    }
}