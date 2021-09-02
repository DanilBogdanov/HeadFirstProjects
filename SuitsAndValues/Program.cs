using System;

namespace SuitsAndValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numFr0To3 = random.Next(4);
            int numFr1To13 = random.Next(1, 14);
            

            Card card = new Card((Suit) numFr0To3, (Value) numFr0To3);
            
            Console.WriteLine(card.Name);
            
        }
    }
}