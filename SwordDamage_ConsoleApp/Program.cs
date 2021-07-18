using System;

namespace SwordDamage_ConsoleApp
{/*1. Create a new instance of the SwordDamage class, and also a
new instance of Random.
2. Write the prompt to the console and read the key. Call
Console.ReadKey(false) so the key that the user typed is printed
to the console. If the key isn’t 0, 1, 2, or 3, return to end the
program.
3. Roll 3d6 by calling random.Next(1, 7) three times and adding
the results together, and set the Roll field.
4. If the user pressed 1 or 3 call SetMagic(true): otherwise call
SetMagic(false). You don’t need an if statement to do this: key
== ’1’ returns true, so you can use || to check the key directly
inside the argument.
5. If the user pressed 2 or 3, call SetFlaming(true); otherwise call
SetFlaming(false). Again, you can do this in a single statement
using == and ||.
6. Write the results to the console. Look carefully at the output and
use \n to insert line breaks where needed.*/
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new ();
            Random random = new();
            
            
        }
    }
}