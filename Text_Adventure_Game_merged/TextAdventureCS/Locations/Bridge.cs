using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Bridge : Location
    {
        public Bridge(string name)
            : base(name)
        {
            
        }

        public override void Description()
        {
            Console.WriteLine("You are standing on a sturdy looking bridge.");
        }
    }
}
