namespace DictionaryExam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, int> _scores = new Dictionary<string, int>();
            _scores.Add("뭉크", 100);
            _scores.Add("꼬미", 3);
            _scores.Add("팽이", 2);
            _scores.Add("띠기", 1);
            _scores.Remove("뭉크");

            foreach(KeyValuePair<string, int> pair in _scores)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
    }
}