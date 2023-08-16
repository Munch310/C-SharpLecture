namespace ConstructorExam
{
    internal class Program
    {
        class Person
        {
            private string _name;
            private int _age;

            // default 생성자
            public Person()
            {
                _name = "UnKnown";
                _age = 0;

            }
            public Person(string _newName, int _newAge)
            {
                _name = _newName;
                _age = _newAge;
                Console.WriteLine("Person 객체 생성");
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {_name}, Age: {_age}");
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person(); // default 생성자
            Person person2 = new Person("Munch", 26); // Person
            person2.PrintInfo();
        }
    }
}