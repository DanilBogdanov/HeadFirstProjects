using System;

namespace PickACardUI
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
            }
            return pickedCards;
        }

        static string RandomSuit()
        {
            int value = random.Next(1, 5);
            /*return value switch
            {
                1 => "Spades",
                2 => "Hearts",
                3 => "Clubs",
                _ => "Diamond",
            };*/
            string result;
            switch (value)
            {
                case 1:
                    result = "Spaders";
                    break;
                case 2:
                    result = "Hearts";
                    break;
                case 3:
                    result = "Clubs";
                    break;
                default:
                    result = "Diamond";
                    break;
            }


            return result;
        }

        static string RandomValue()
        {
            int value = random.Next(1, 14);
            string result;/*= value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => value.ToString()
            };*/

            switch (value)
            {
                case 1:
                    result = "Ace";
                    break;
                case 11:
                    result = "Jack";
                    break;
                case 12:
                    result = "Queen";
                    break;
                case 13:
                    result = "King";
                    break;
                default:
                    result = value.ToString();
                    break;
            }
            return result;

        }
    }
}
