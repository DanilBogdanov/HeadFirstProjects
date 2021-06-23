using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardsPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Your input is incorrect. Try again.");
            }
        }
    }
}
