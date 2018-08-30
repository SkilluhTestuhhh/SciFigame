using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Lore_edits
{
    class Story
    {
        public Story()
        {
            Console.WriteLine("As you walked through the door you got into a smaller hall that had a lot of doors going to the dorms of the knights.");
            // The intro and beginning zijn al ge inplement in de program.cs

            // Door de Console.ForegroundColor zal alle tekst wit zijn, en de woorden die worden gezegd door characters grijs voor betere leesbaarheid.


            // After player arrived at the church
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

            // After battle with the knight/Lewis
            Console.WriteLine("After you defeated Lewis you looked around to see that we won the fight, most of the enemies were beaten,");
            Console.WriteLine("and the few surviving infected quickly fled away. A few knights have gotten heavily wounded,");
            Console.WriteLine("so the group decided to split into two. One half went back to the Raven base with the wounded,");
            Console.WriteLine("and you and the others continued the mission.");
            Console.WriteLine();

            // Entering church
            Console.WriteLine("The church was old and partly broken down.  On all the objects inside a small layer of dust had formed,");
            Console.WriteLine("indicating that no one has been here in a very long time.");
            Console.WriteLine("You decided to look at the desk with a cross on top that was located in front of the church.");
            Console.WriteLine("In one of the drawers of the desk you found what you were send to look for, the artifact.");
            Console.WriteLine("A shiny golden statue of a Raven. In other places ravens are often connected to death,");
            Console.WriteLine("but here… they were a sign of divine power.");
            Console.WriteLine();
            Console.WriteLine("As you showed what you found to the other knights, you all headed back to base.");
            Console.ReadLine();
            Console.Clear();
            // Obtained item: artifact

            //Back at base
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
            Console.WriteLine("to their leader will weaken his powers, and allow you to kill him.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("He explained.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“Everyone of division 8 that can still fight, will head over to the abandoned town now!");
            Console.WriteLine("We’ll send division 3 and 4 with you.”");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Once de player aankomat in de abandoned town
            Console.WriteLine("As the group of knights marched into the abandoned town, they were surrounded by the enemy once again.");
            Console.WriteLine("All the knights around you started to attack the people. That was to weaken the enemies, but also");
            Console.WriteLine("to distract from the fact that you were going to sneak behind enemy lines, and kill their leader.");
            Console.WriteLine();
            Console.WriteLine("That is the plan at least...");
            Console.WriteLine("You were told that the leader hid himself in a dungeon-like cave that could be accessed from the abandoned town.");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            // Once the player enters the dungeon
            Console.WriteLine("Quietly you managed to find the entrance to the dungeon and were able to sneak in without getting caught.");
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
            Console.WriteLine("”So why... don't you grab that artifact and smash it on the ground? Let it fall into a thousand pieces,");
            Console.WriteLine("And I will grant you amazing powers.”");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;


            // GOOD ENDING

            Console.WriteLine("Never! Those misleading words don't have effect on you!");
            Console.WriteLine("You immediately draw your weapon and close in the distance between yuo and the leader, ready to fight.");
            // After fight
            Console.WriteLine("As soon as the man stopped breathing it got quiet outside. Deadly quiet.");
            Console.WriteLine("You quickly rushed outside to see how the situation has unfolded itsself");
            Console.WriteLine("now that the leader of the infected has died.");
            Console.WriteLine();
            Console.WriteLine("All the citizens that were previously attacking the Ravens now stood in confusion,");
            Console.WriteLine("looking around at where they are and what exactly happend.");
            Console.WriteLine();
            Console.WriteLine("The curse has been lifted! And it is all thanks to you {0}", Player.GetName());
            Console.WriteLine();
            Console.WriteLine("GOOD END");


            // BAD ENDING

            Console.WriteLine("This offer is... very tempting. You got the artifact out of your bag and looked at it for a second,");
            Console.WriteLine("before throwing it at the harsh stone floor, shattering the beautiful Raven into a thousand pieces.");
            Console.WriteLine();
            Console.WriteLine("The leader smirked as he put his hand on your shoulder.");
            Console.WriteLine("As he talked to you you felt an incredible power taking you over.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”Now wouldn't you want to take revenge on the man who prevented you from being this way for so long?!”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The leader said exactly what you were thinking. Who you have been working with were actually the enemies!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”I know who you have in mind... Go and take revenge on your commander.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Everything he said was repeated in your mind, anad you listened to it without thinking.");
            Console.WriteLine();
            Console.WriteLine("All you were focused on was ending the life of commander Avalon. You immediately returned to the Raven base.");
            Console.WriteLine();
            // After player returned to Raven base.
            Console.WriteLine("You stromed in through the gates of the base and aggressively searched around the base.");
            Console.WriteLine("Eventually you found Avalon sitting outsid alone, coming up with plans to fight the infected.");
            Console.WriteLine();
            Console.WriteLine("You drew your weapon and pointed it at commander Avalon with a dark grin. Yes... Revenge...");
            Console.WriteLine("Avalon reacted very surprised to see you in a state like this.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”{0}! What is the meaning of thi- ...You're infected...”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("He sounded very dissapointed, in you, and himself.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”I shouldn't have send someone still so new to complete such an important task.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("he thought out loud.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”But, I can't have you hurt anyone. So I will stop you at all costs.”");
            Console.ForegroundColor = ConsoleColor.White;
            // After fight
            Console.WriteLine("Defeating the commander of the Ravens was an amazing start.");
            Console.WriteLine();
            Console.WriteLine("Soon all the remaining Ravens were killed.");
            Console.WriteLine("And there was no one to protect the citizens from danger anymore.");
            Console.WriteLine();
            Console.WriteLine("And the land got taken over... All because of your choice.");
            Console.WriteLine();
            Console.WriteLine("EVIL END");
        }
    }
}
