using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Dialoge
    {
        public void showChurchEnter()
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
        }

        public void showChurchExit()
        {
            Console.WriteLine("After you defeated Lewis you looked around to see that we won the fight, most of the enemies were beaten,");
            Console.WriteLine("and the few surviving infected quickly fled away. A few knights have gotten heavily wounded,");
            Console.WriteLine("so the group decided to split into two. One half went back to the Raven base with the wounded,");
            Console.WriteLine("and you and the others continued the mission.");
            Console.WriteLine();
            Console.WriteLine("The church was old and partly broken down.  On all the objects inside a small layer of dust had formed,");
            Console.WriteLine("indicating that no one has been here in a very long time.");
            Console.WriteLine("You decided to look at the desk with a cross on top that was located in front of the church.");
            Console.WriteLine("In one of the drawers of the desk you found what you were send to look for, the artifact.");
            Console.WriteLine("A shiny golden statue of a Raven. In other places ravens are often connected to death,");
            Console.WriteLine("but here… they were a sign of divine power.");
            Console.WriteLine();
            Console.WriteLine("You figured that Lewis had infiltrated into the Ravens to make sure we wouldn't be able");
            Console.WriteLine("to retrieve the artifact. But we did, and the artifact seemed to keep ");
            Console.WriteLine("pointing in a certain direction...To the east");
            Console.WriteLine("As you showed what you found to the other knights, you all headed back to base.");
            Console.ReadLine();
            Console.Clear();
        }

        public void showEnd(bool Artifact)
        {
            if (Artifact == true)
            {
                Console.WriteLine("You defeated the manifastation, finally this war will be over.");
                Console.WriteLine("The artifact protected you from the infection. Once the boss was defeaten");
                Console.WriteLine("it's power left his body, wanting to target you. But since you had the artifact");
                Console.WriteLine("on you, it got destroyed the moment it got close to you.");
                Console.WriteLine("The moment you defeated the boss everything gto quiet outside.");
                Console.WriteLine("You rushed outside to see how the situation outside has unfolded.");
                Console.WriteLine();
                Console.WriteLine("Once you got out off the dungeon you saw the people who were first attacking the Ravens,");
                Console.WriteLine("now looking around, stunned. Confused of how they ended up here and what was even going on.");
                Console.WriteLine("But, they were alright. Everyone will be alright. This horrible curse was lifted and ");
                Console.WriteLine("soon this land will turn back to normal.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("= = = = = = = GOOD END = = = = = = =");
                Console.ReadLine();

            }
            else if(Artifact == false)
            {
                Console.WriteLine("You have defeated their leader, but the artifact was needed for more than to only weaken the boss.");
                Console.WriteLine("The manifastation may be gone but... that curse isn't. The amazing power of the boss went into you,");
                Console.WriteLine("completely taking you over.");
                Console.WriteLine("If you hadn't been with those Ravens you could have had this power so much earlier!");
                Console.WriteLine("You suddenly felt the need for revenge.... you exited the dungeon.");
                Console.WriteLine();
                Console.WriteLine("You immediately went back to the Raven base, ignoring the fact that the fight outside was");
                Console.WriteLine("still ongoing, and more and more sacrifices were made.");
                Console.WriteLine();
                Console.WriteLine("Driven by your anger, by your need for revenge... the Ravens will fall.");
                Console.WriteLine("First their base, and then slowly their organization will start to fall apart.");
                Console.WriteLine("And then, once they are defeaten, eveyone else is next...");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("= = = = = = = BAD END = = = = = = =");
                Console.ReadLine();
            }
        }

        public void showCredits()
        {
            Console.Clear();
            Console.WriteLine("CREDITS:");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("CODING:");
            Console.WriteLine("    Geert");
            Console.WriteLine("    Thijs");
            Console.WriteLine();
            Console.WriteLine("STORY:");
            Console.WriteLine("    Laura");
            Console.WriteLine("    Gijs");
            Environment.Exit(0);

        }

    }
}
