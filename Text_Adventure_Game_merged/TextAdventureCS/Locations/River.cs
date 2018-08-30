using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class River : Location
    {
        public River(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You see a river before you.");

        }
    }
}
