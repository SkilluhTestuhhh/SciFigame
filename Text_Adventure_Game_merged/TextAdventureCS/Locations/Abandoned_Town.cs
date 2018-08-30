using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Abandoned_Town : Location
    {
        public Abandoned_Town(string name)
            : base(name)
        {
            Diamond dia = new Diamond("Diamond", true);
            items.Add(dia.GetName(), dia);
        }

        public override void Description()
        {
            Console.WriteLine("As the group of knights marched into the abandoned town, they were surrounded by the enemy once again.");
            Console.WriteLine("All the knights around you started to attack the people. That was to weaken the enemies, but also");
            Console.WriteLine("to distract from the fact that you were going to sneak behind enemy lines, and kill their leader.");
            Console.WriteLine();
            Console.WriteLine("That is the plan at least...");
            Console.WriteLine("You were told that the leader hid himself in a dungeon-like cave that could be accessed from the abandoned town.");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            /* Console.WriteLine("Among the ruined walls of a once great city, you entered through what once was a gate meant.");
            Console.WriteLine("Inside you find the city devoit of any sound.. ");
            Console.WriteLine("In the middle you find a building that seems otherwordly, out of place even."); */
        }
    }
}
