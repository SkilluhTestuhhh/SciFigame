using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAdventureCS
{
    class Utility
    {
        static public void Text(string print, int textSpeed)
        {
            foreach (char l in print)
            {
                Console.Write(l);
                Thread.Sleep(textSpeed);
            }
            Console.Write("\n");
        }
    }
}

