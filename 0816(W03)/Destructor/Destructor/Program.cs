using System.Security.Cryptography.X509Certificates;

namespace Destructor
{
    internal class Program
    {
        class Person
        {
            private string _name;

            public Person(string _newName)
            {
                _name = _newName;
                Console.WriteLine("Person 객체 생성");
            }
            ~Person() // 소멸자
            {
                Console.WriteLine("Person 객체 소멸");
            }
        }
        
        
        static void Main(string[] args)
        {
            Person p = new Person("Munch");

        }
    }
}