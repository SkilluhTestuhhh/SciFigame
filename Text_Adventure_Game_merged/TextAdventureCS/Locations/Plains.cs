using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Plains : Location
    {
        public Plains(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in grassfield.");
        }
    }
}
