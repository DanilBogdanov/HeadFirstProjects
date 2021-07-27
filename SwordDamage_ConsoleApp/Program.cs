using System;

namespace SwordDamage_ConsoleApp
{
    class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new(RollDice());
            
            string hint = "0 for no magic/flaming, 1 for magic, 2 flaming, 3 for both, anything else to quit: ";

            while (true)
            {
                Console.Write(hint);
                char key = Console.ReadKey(false).KeyChar;

                if (key is < '0' or > '3')
                {
                    return;
                }

                swordDamage.Roll = RollDice();
                swordDamage.Magic = key is '1' or '3';
                swordDamage.Flaming = key is '2' or '3';

                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
            }
        }

        private static int RollDice()
        {
            return _random.Next(1, 7) + _random.Next(1, 7) + _random.Next(1, 7);
        }
    }
}