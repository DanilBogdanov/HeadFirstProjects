using System;

namespace Shoes
{
    class Program
    {
        private static ShoeCloset _shoeCloset = new ShoeCloset();

        static void Main(string[] args)
        {
            while (true)
            {
                _shoeCloset.PrintShoes();
                Console.WriteLine("\nPress 'a' to add or 'r' to remove a shoe:  ");
                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'a':
                    case 'A':
                    {
                        _shoeCloset.AddShoe();
                        break;
                    }
                    case 'r':
                    case 'R':
                    {
                        _shoeCloset.RemoveShoe();
                        break;
                    }
                    default:
                        return;
                }
            }
        }
    }
}