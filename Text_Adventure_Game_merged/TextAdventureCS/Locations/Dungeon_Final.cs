using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Dungeon_Final : Location
    {
        public Dungeon_Final(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("All the infected were distracted by the fight going on outside, so no one was in this dungeon anymore.");
            Console.WriteLine("Except... for the leader.");
            Console.WriteLine("At the end of the dungeon you saw him. The man that caused all these horrible things to these people...");
            Console.WriteLine("The leader you were facing had it's back turned to you, until you approached a bit closer.");
            Console.WriteLine("He immediately turned around.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“Ah, So the Ravens did succesfully retrieve the artifact... such a shame.“");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("He spoke like he didn't mean a word of what he said.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“But I was actually quite excited to see one of you guys run up to me like that and try to defeat me.");
            Console.WriteLine("You see... what I am doing isn't necesarily bad. This virus, it gives people power. The power they deserve.“");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Slowly the villain approached you.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”And I will not let you Ravens take this power away from me, or from anyone I have infected!!”");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
