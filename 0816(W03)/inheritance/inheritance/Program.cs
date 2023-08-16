namespace inheritance
{
    internal class Program
    {
        public class Animal
        {
            // 부모 클래스
            public string _name { get; set; } // 프로퍼티
            public int _age { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{_name} is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{_name} is sleeping");
            }

        }

        // 자식 클래스
        public class Dog : Animal // 자식 : 부모 = 상속! 
        {
            public void Bark()
            {
                Console.WriteLine($"{_name} is bark");
            }
        }

        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"{_name} is meow");
            }

            public void Sleep()
            {
                Console.WriteLine($"{_name} sleep!");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog._name = "Bobby";
            dog._age = 3;

            dog.Eat();
            dog.Sleep();
            dog.Bark();

            Cat cat = new Cat();
            cat._name = "Ggomme";
            cat._age = 1;

            cat.Eat();
            cat.Sleep(); // 부모의 Sleep보다 Cat의 Sleep이 더 가깝기 때문에 Cat.Sleep을 호출
            cat.Meow();
        }
    }
}