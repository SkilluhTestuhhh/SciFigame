using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Fort : Location
    {
        public Fort(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            int visitedBase = 0;
            if (visitedBase == 0)
            {
                Console.WriteLine("you walk towards a large fort like structure.");
                Console.WriteLine("Banners decorated with ravens flutter in the wind as you enter the courtyard.");

            }
            else if (visitedBase == 1)
            {
               
                Console.WriteLine("Once back at the Raven base, your division was greeted by commander Avalon.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“I saw the wounded come back earlier and heard you were ambushed. I’m glad everyone is still alive.");
                Console.WriteLine("On another note, did you succeed in retrieving the artifact?”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You quickly got the artifact you found out of your bag and showed it to the commander.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“amazing… yes! This will be able to lift the curse from everyone. You see, this artifact contains divine power");
                Console.WriteLine(" that has saved this land before, but It got lost… I wonder how it ended up in that old church.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Avalon continued talking.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“We have found out that there is some sort of system with how people get infected.");
                Console.WriteLine("Apparently the source of it all is only one person, who infects all the others and makes them lose control and");
                Console.WriteLine("listen to everything he says. Once you kill him, everyone who was ever infected will turn back to normal.");
                Console.WriteLine("And now with this artifact you found, we can!”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The commander spoke with confidence.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“like I said before this artifact contains divine power, only having it close");
                Console.WriteLine("to you will prevent you from being infected, and allow you to kill him.”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("He explained.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“Everyone of division 8 that can still fight, will head over to the abandoned town now!");
                Console.WriteLine("We’ll send division 3 and 4 with you.”");
                Console.WriteLine();
                Console.WriteLine("You were told to head south-east en cross the bridge to find the abandoned town.");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                visitedBase += 1;
            }
        }
    }
}
