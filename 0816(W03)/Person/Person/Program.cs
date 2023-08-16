namespace Person
{
    internal class Program
    {
        class Person
        {
            public string Name;
            public int Age;

            public void PrintInfo()
            {
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Age : " + Age);
            }
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            p.Age = 30;
            p.PrintInfo();
        }
    }
}