using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Dungeon_1 : Location
    {
        public Dungeon_1 (string name)
            : base(name)
        {

            hasEnemy = true;
        }

        public override void Description()
        {
            Console.WriteLine("You have stepped into a what would seem like a tomb or a burial place of somekind.");
            Console.WriteLine("The walls have large gaps with decorated coffins in them. It would be wise not to disturb the coffins");
        }
    }
}
