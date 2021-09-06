using System;
using System.Collections.Generic;

namespace SuitsAndValues
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Console.WriteLine("Enter number of card");
            
            if (int.TryParse(Console.ReadLine(), out int result) &&
                result > 0)
            {
                for (int i = 0; i < result; i++)
                {
                    cards.Add(GenerateARandomCard());
                }
            }

            PrintCards(cards);
            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n-----------");
            PrintCards(cards);
        }

        private static Card GenerateARandomCard()
        {
            Random random = new Random();
            int numFr0To3 = random.Next(4);
            int numFr1To13 = random.Next(1, 14);
            Card randomCard = new Card((Suit)numFr0To3, (Value)numFr1To13);

            return randomCard;
        }

        private static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}