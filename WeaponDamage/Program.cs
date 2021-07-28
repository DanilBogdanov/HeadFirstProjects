using System;

namespace WeaponDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"\nS for sword, A for arrow, anything else to quit: ");
            char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

            switch (weaponKey)
            {
                case 'S':

                    break;
                case 'A':

                    break;
                default:
                    return;
            }
        }
    }
}
