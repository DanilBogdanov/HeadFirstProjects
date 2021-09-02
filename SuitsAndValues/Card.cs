namespace SuitsAndValues
{
    public class Card
    {
        public Suit Suit { get;private set; }
        public Value Value { get; private set; }
        public string Name => $"{Suit} of {Value}";

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }
}