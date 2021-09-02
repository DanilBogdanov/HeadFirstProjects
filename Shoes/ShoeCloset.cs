using System;
using System.Collections.Generic;

namespace Shoes
{
    public class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}");
            }

            Console.WriteLine("Enter a style: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.WriteLine("\nEnter the color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style) style, color);
                shoes.Add(shoe);
            }
        }

        public void RemoveShoe()
        {
            Console.WriteLine("\nEnter the number of the shoe to remove: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) &&
                shoeNumber >= 1 && shoeNumber <= shoes.Count)
            {
                Console.WriteLine($"\nRemoving {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }
        }

        public void PrintShoes()
        {
            if (shoes.Count == 0)
            {
                Console.WriteLine("\nThe shoe closet is empty.");
            }
            else
            {
                Console.WriteLine("\nThe shoe closet contains:");
                int i = 0;
                foreach (Shoe shoe in shoes)
                {
                    i++;
                    Console.WriteLine($"Shoe #{i}: {shoe.Description}");
                }
            }
        }
    }
}