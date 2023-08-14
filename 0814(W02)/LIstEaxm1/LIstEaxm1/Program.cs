namespace LIstEaxm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> _list = new List<int>();
            _list.Add(1);
            _list.Add(2);
            _list.Add(3);

            _list.Remove(2);

            // Lenth아닌 Coint쓰기!
            for(int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine(_list[i]);
            }

            foreach(int i in _list)
            {
                Console.WriteLine(i);
            }
        }
    }
}