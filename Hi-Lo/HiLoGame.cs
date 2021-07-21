using System;
using System.Runtime.CompilerServices;

namespace Hi_Lo
{
    /*5. A method called Guess with a bool parameter called higher
that does the following (look closely at the Main method to see
how it’s called):
It picks the next random number for the player to guess.
If the player guessed higher and the next number is >=
the current number OR if the player guessed lower and
the next number is <= the current number, write “You
guessed right!” to the console and increment the pot.
Otherwise, write “Bad luck, you guessed wrong.” to
the console and decrement the pot.
Replace the current number with the one chosen at the
beginning of the method and writes “The current
number is” followed by the number to the console.
6. A method called Hint that finds half the maximum, then writes
either “The number is at least {half}” or “The number is at most
{half}” to the console and decrements the pot.*/
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(0, MAXIMUM);
        private static int pot = MAXIMUM;

        public static void Guess(bool higher)
        {
            
        }

        public static int GetPot()
        {
            return pot;
        }
        public static void Hint()
        {
            
        }
    }
}