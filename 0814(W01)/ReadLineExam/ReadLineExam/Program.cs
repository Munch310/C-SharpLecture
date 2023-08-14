using System;

namespace ReadLineExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello,{0}!", name);

            // Split + ReadLine()
            Console.WriteLine("Enter two numbers : ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);

            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
        }


        
    }
}