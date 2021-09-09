using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    internal class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Add(new Card((Suit)i, (Value)j));
                }
            }
        }

        public Card Deal(int index)
        {
            return null;
        }

        public void Shuffle()
        {
            List<Card> cards = new List<Card>(this);
            Clear();
            
            while (cards.Count > 0)
            {
                int item = random.Next(cards.Count);
                Add(cards[item]);
                cards.RemoveAt(item);
            }
        }

        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparerByValue());
            Clear();

            foreach (Card card in sortedCards)
            {
                Add(card);
            }
        }
    }
}
