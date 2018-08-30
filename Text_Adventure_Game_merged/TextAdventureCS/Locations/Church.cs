using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Church : Location
    {
        int churchVisit = 0;

        public Church(string name)
            : base(name)
        {
            hasEnemy = true;
        }

        public override void Description()
        {
            
            if (churchVisit == 0)
            {
                Console.WriteLine("As you head towards the church Lewis glanced over at you and gave a reassuring smile.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“You’re nervous, aren’t you? Heh, you don’t have to be!”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("He roughly patted you on the back as he continued speaking.");
                Console.WriteLine("“Those infected may seem scary at first… but it’ll be alright, there’s nothing dangerous about them!”");
                Console.WriteLine("He cheerfully spoke, you already felt less afraid by just listening to his words.");
                Console.WriteLine();

                Console.WriteLine("Apart from the small talk the knights had with each other, everything stayed quiet. As they walked further,");
                Console.WriteLine("slowly a small building with a cross on top of the roof had gotten closer, they were almost at the church.");
                Console.WriteLine("But before they were able to get close enough to the entrance, the group of knights were ambushed.");
                Console.WriteLine();

                Console.WriteLine("In an instant the division was surrounded by enemies.");
                Console.WriteLine("People with completely black eyes, which was typical for people affected by this horrible curse.");
                Console.WriteLine("there was no use trying to talk to these people anymore. All they want is death and destruction.");
                Console.WriteLine("As we were surrounded by the enemies, one of them stepped forward.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“Glad we have one of ours infiltrated in this group!”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The infected shouted followed by a mean laugh.");
                Console.WriteLine("And at that exact moment Lewis drew his sword and stabbed it right through the chest of one of your comrades.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“Heh”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("He chuckled as he turned around to the group of knights and took off his helmet,");
                Console.WriteLine("revealing the same black eyes as the infected have.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("“I told you it was a good idea.”");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Lewis responded.");
                Console.WriteLine();
                Console.WriteLine("There was no time to think about how the leader of their division just betrayed us all,");
                Console.WriteLine("because the other infected started to attack the fellow knights,");
                Console.WriteLine("leaving you facing the man who you thought was your ally not even a minute ago.");
                Console.ReadLine();
                Console.Clear();

                churchVisit += 1;
            }
            else if (churchVisit == 1)
            {
                Console.WriteLine("You are standing in front of a church.");
            }
        }
    }
}
