using System;

namespace SwordDamage_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new();
            Random random = new();
            string hint = "0 for no magic/flaming, 1 for magic, 2 flaming, 3 for both, anything else to quit: ";

            while (true)
            {
                Console.Write(hint);
                char key = Console.ReadKey(false).KeyChar;

                if (key < '0' || key > '3')
                {
                    return;
                }

                swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');

                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
            }
        }
    }
}