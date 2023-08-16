namespace BlackJackGame
{
    internal class Program
    {
       public enum Suit { Hearts, Diamonds, Clubs, Spades}
       public enum Rank { Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 'J', Queen = 'Q', King = 'K', Ace = 'A'}

        public class Card
        {
            public Suit Suit { get; private set; }
            public Rank Rank { get; private set; }
            public Card(Suit s, Rank r)
            {
                Suit = s;
                Rank = r;
            }
        }
    }
}