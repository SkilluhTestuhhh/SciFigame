using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Dungeon_2 : Location
    {
        public Dungeon_2(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You walk into a large hall way, the stones are damp, and the torches among the walls are unlit.");
            Console.WriteLine("Among the walls are decorated suits of armor. you get the odd feeling you are being watched.");
            
        }
    }
}
