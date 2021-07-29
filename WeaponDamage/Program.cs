using System;

namespace WeaponDamage
{
    class Program
    {
        private static Random _random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            string hint = "0 for no magic/flaming, 1 for magic, 2 flaming, 3 for both, anything else to quit: ";

            while (true)
            {
                Console.Write(hint);
                char key = Console.ReadKey(false).KeyChar;

                if (key is < '0' or > '3')
                {
                    return;
                }

                Console.Write($"\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = key is '1' or '3';
                        swordDamage.Flaming = key is '2' or '3';

                        Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
                        break;
                    case 'A':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = key is '1' or '3';
                        arrowDamage.Flaming = key is '2' or '3';

                        Console.WriteLine($"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP");
                        break;
                    default:
                        return;
                }
            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int result = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                result += _random.Next(1, 7);
            }
            return result;
        }
    }
}
