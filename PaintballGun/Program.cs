using System;

namespace PaintballGun
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Number of balls");
            int magazineSize = ReadInt(16, "Magazine size");
            Console.Write("Loaded [false]: ");
            bool isLoaded = bool.TryParse(Console.ReadLine(), out bool parsedLoaded);
            
            PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);
            
            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
                if (gun.IsEmpty())
                {
                    Console.WriteLine("Warning:You're out of ammo");
                }

                Console.WriteLine("Space to shoot, r to reload, + to add ammo," +
                                  "q to quit");
                char key = Console.ReadKey(true).KeyChar;

                if (key == ' ')
                {
                    Console.WriteLine($"Shooting returned {gun.Shoot()}");
                }
                else if (key == 'r')
                {
                    gun.Reload();
                }
                else if (key == '+')
                {
                    gun.Balls += gun.MagazineSize;
                }
                else if (key == 'q')
                {
                    return;
                }
            }

        }

        private static int ReadInt(int defaultNumber, string promt)
        {
            Console.WriteLine($"{promt} [default:{defaultNumber}]");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                return defaultNumber;
            }
        }
    }
}