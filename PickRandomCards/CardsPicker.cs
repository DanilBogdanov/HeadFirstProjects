using System;

namespace PickRandomCards
{
    class CardsPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
                RandomSuit();
            }
            return pickedCards;
        }
        
        static string RandomSuit()
        {
            int value = random.Next(1, 5);
            return value switch
            {
                1 => "Spades",
                2 => "Hearts",
                3 => "Clubs",
                _ => "Diamond",
            };
        }

        static string RandomValue()
        {
            int value = random.Next(1, 14);
            return value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => value.ToString()
            };
        }
    }
}
