namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack<int> _stack1 = new Stack<int>();

            _stack1.Push(1);
            _stack1.Push(2);
            _stack1.Push(3);

            int _value = _stack1.Pop(); // _value = 1


            // Queue
            Queue<int> _queue1 = new Queue<int>();
            _queue1.Enqueue(1);
            _queue1.Enqueue(2);
            _queue1.Enqueue(3);

            int _value1 = _queue1.Dequeue(); // _value1 = 1

            // HashSet
            HashSet<int> _set1 = new HashSet<int>();

            _set1.Add(1);
            _set1.Add(2);
            _set1.Add(3);

            foreach(int _element in _set1)
            {
                Console.WriteLine(_element);
            }
        }
    }
}