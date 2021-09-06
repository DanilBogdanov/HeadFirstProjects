using System;
using System.Collections.Generic;
using System.Linq;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 17},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 18},
                new Duck() {Kind = KindOfDuck.Loon, Size = 14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = KindOfDuck.Loon, Size = 13},
            };

            
            
            IEnumerable<Bird> upcastDuck = ducks;
            Bird.FlyAway(upcastDuck.ToList(), "Usa");

            ducks.Sort(new DuckComparerBySize());
            PrintDucks(ducks);
        }

        private static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
    }
}
