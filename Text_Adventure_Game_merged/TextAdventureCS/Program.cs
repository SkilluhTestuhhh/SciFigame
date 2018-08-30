using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Originally made by Sietse Dijks
// Releasedate: 18-01-2014
// Current version: 1.5
// Last changes by: Michiel Pot and Alex van Pelt
// Change Date: 09-01-2015

namespace TextAdventureCS
{
    class Program
    {
        // Define the directions available to the player.
        // Refactored by Michiel and Alex
        const string MOVE_NORTH = "Go North";
        const string MOVE_WEST = "Go West";
        const string MOVE_SOUTH = "Go South";
        const string MOVE_EAST = "Go East";
        
        // Cluster the directions for validation purposes.
        // Refactored by Michiel and Alex
        static List<string> validDirections = new List<string> {
            MOVE_NORTH, 
            MOVE_WEST, 
            MOVE_SOUTH, 
            MOVE_EAST        
        };

        // Refactored by Michiel and Alex
        const string ACTION_SEARCH = "Enter Dungeon";
        const string ACTION_FIGHT = "Fight";
        const string ACTION_RUN = "Run";
        const string ACTION_QUIT = "Exit";

        static void Main(string[] args)
        {
            // General initializations to prevent magic numbers
            int mapwidth = 9;
            int mapheight = 9;
            int xstartpos = 1;
            int ystartpos = 0;
            // Welcome the player
            Console.WriteLine("Welcome to a textbased adventure");
            Console.WriteLine("Before you can start your journey, you will have to enter your name.");

            string name = null;
            string input = null;

            // Check for the correct name
            // Refactored from do - while to improve readability by Michiel and Alex
            while(input != "Y") 
            {
                if( input == null || input == "N" )
                {
                    Console.WriteLine("Please enter your name and press enter:");
                    name = Console.ReadLine();
                }

                Console.WriteLine("Your name is {0}",name);
                Console.WriteLine("Is this correct? (y/n)");
                input = Console.ReadLine();
                input = input.ToUpper();
            }           

            // Make the player
            Player player = new Player(name, 100);
            //Welcome the player
            Welcome(ref player);

            // Initialize the map
            Map map = new Map(mapwidth, mapheight, xstartpos, ystartpos);
            // Put the locations with their items on the map
            InitMap(ref map);
            // Start the game
            Start(ref map, ref player);
            // End the program
            Quit();
        }

        static void Welcome(ref Player player)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the world of Flightwood");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Around half a year ago someone obtained a certain power that brought darkness upon this land.");
            Console.WriteLine("Once he infected someone with these powers it strengthened their worst traits,");
            Console.WriteLine("causing most of them to cause death and destruction everywhere they go.");
            Console.WriteLine("They have grouped up and are working together to infect as many people as possible.");
            Console.WriteLine("If this continues, the whole world will come to an end.");
            Console.WriteLine();
            Console.WriteLine("But there is a group of knights that stayed strong in these times of darkness,");
            Console.WriteLine("that are protecting the vulnerable citizens against the darkness of this infection: The Ravens.");
            Console.WriteLine("And you decided to join them!");
            Console.WriteLine();
            Console.WriteLine("After a long travel you see it, the legendary Raven base.");
            Console.WriteLine("You are standing in front of the gates of the big castle that you’ve heard so much stories of.");
            Console.WriteLine();
            Console.WriteLine("You’re about to be one of the Ravens.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Slowly the tall gates open up in front of you, and you enter the entrance hall of the Raven base.");
            Console.WriteLine("The hall is gigantic, and everything looks very neat. You stand there in silence, waiting for something to happen.");
            Console.WriteLine();
            Console.WriteLine("A few minutes later you heard footsteps coming closer,");
            Console.WriteLine("the person walked towards you from the end of the hall, revealing himself as he walked up to you.");
            Console.WriteLine("The man was wearing shining armor with the logo of the Ravens printed on top of the chestplate,");
            Console.WriteLine("as well as on the cape that flows behind him.");
            Console.WriteLine("His piercing gaze looking right through you as he stuck out his hand waiting for you to shake it.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“You are the new recruit, aren’t you? I am Avalon, and I will be your commander.");
            Console.WriteLine( "It is nice to meet you {0}.”", player.GetName());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Both of you started to slowly walk to the big doors at the end of the halls as the conversation continued.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("”As you know, you’re here to fight against the people who got infected.”");
            Console.WriteLine("As of now most of them have gathered in the abandoned town were the source is, they’re protecting it.");
            Console.WriteLine("And we are trying to infiltrate into the town.");
            Console.WriteLine("We are hoping that when the source is destroyed the infection will disappear, and everyone will be saved.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your new commander explained.");
            Console.WriteLine("As you walked through the door you got into a smaller hall that had a lot of doors going to the dorms of the knights.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“It is late, you should rest and prepare yourself for tomorrow. This is your room.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Avalon pointed to one of the doors and then left.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You entered your room.");
            Console.WriteLine();
            Console.WriteLine("Not much later you fell asleep.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("The next day you woke up from the sound of multiple footsteps marching in the halls outside of your door.");
            Console.WriteLine();
            Console.WriteLine("You put on the typical Raven armor that was neatly put in your room before quickly exiting through the door.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Outside commander Avalon was waiting for you, ready to explain to you what you are going to do.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“Alright {0}. In the mornings you will gather with your division,", player.GetName());
            Console.WriteLine("have a quick breakfast and then go out on your assigned mission. Your division is division 8");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Avalon called one of the knights that was walking past them in the hall. The knight was already wearing his helmet,");
            Console.WriteLine("seeming like he has already prepared for whatever he is assigned to do today.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“Ah Lewis, this is the newest member of your division, {0}. Will you show {0} how everything works?”", player.GetName());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Avalon introduced you to the knight before rushing off to continue with more important business.");
            Console.WriteLine();
            Console.WriteLine("The man called Lewis then turned to you.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“It’s nice to meet you. Our division has to go on a mission today,");
            Console.WriteLine("so this is a great opportunity to get introduced with the job.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("He then took you to the room where the rest of division 8 was having breakfast,");
            Console.WriteLine("and he explained what we were going to do today.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("“Our Division is assigned to go to a church not far from here, we heard from an anonymous source");
            Console.WriteLine("that there is some sort of artifact there that will be essential to defeating our enemies.”");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("After everything got explained the Division left the Raven base, up to the church.");
            Console.WriteLine("You were told that you needed to head south to find the church.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("There are some tough enemies up ahead.");
            Console.WriteLine("Maybe it is a smart idea for you to train a bit before attempting to fight the strongest");
            Console.WriteLine("enemy in this world!");
            Console.ReadLine();
            Console.Clear();

            player.ShowInventory();

            Console.WriteLine("Press a key to continue..");
            Console.ReadKey();
        }

        static void InitMap(ref Map map)
        {
            // Add locations with their coordinates to this list.
            Fort ravenfort = new Fort("Raven Fort");
            River river = new River("Waters");
            Plains grasslands = new Plains("Grass Lands");
            Forrest forrest = new Forrest("Black Forrest");
            Bridge bridge = new Bridge("Old wooden Bridge");
            Church church = new Church("Old Chapel");
            Abandoned_Town Town = new Abandoned_Town("Ruined City");
            //0
            map.AddLocation(grasslands, 0, 0);
            map.AddLocation(ravenfort, 0, 1);
            map.AddLocation(grasslands, 0, 2);
            map.AddLocation(river, 0, 3);
            map.AddLocation(forrest, 0, 4);
            map.AddLocation(forrest, 0, 5);
            //1
            map.AddLocation(grasslands, 1, 0);
            map.AddLocation(grasslands, 1, 1);
            map.AddLocation(grasslands, 1, 2);
            map.AddLocation(bridge, 1, 3);
            map.AddLocation(forrest, 1, 4);
            map.AddLocation(forrest, 1, 5);
            //2
            map.AddLocation(grasslands, 2, 0);
            map.AddLocation(grasslands, 2, 1);
            map.AddLocation(grasslands, 2, 2);
            map.AddLocation(river, 2, 3);
            map.AddLocation(grasslands, 2, 4);
            map.AddLocation(forrest, 2, 5);
            //3
            map.AddLocation(grasslands, 3, 0);
            map.AddLocation(church, 3, 1);
            map.AddLocation(grasslands, 3, 2);
            map.AddLocation(river, 3, 3);
            map.AddLocation(Town, 3, 4);
            map.AddLocation(Town, 3, 5);
            //4
            
            map.AddLocation(grasslands, 4, 0);
            map.AddLocation(grasslands, 4, 1);
            map.AddLocation(grasslands, 4, 2);
            map.AddLocation(river, 4, 3);
            map.AddLocation(Town, 4, 4);
            map.AddLocation(Town, 4, 5);

            /*            Cliff cliff = new Cliff("Rockface");
            map.AddLocation(cliff, 0, 3);*/
            /*            Swamp swamp = new Swamp("Bog");
            map.AddLocation(swamp, 0, 1);*/

            //Dungeon
            Dungeon_1 dungeon_1 = new Dungeon_1("Crypt");
            map.AddLocation(dungeon_1, 3, 7);
            Dungeon_2 dungeon_2 = new Dungeon_2("Crypt");
            map.AddLocation(dungeon_2, 1, 7);
            map.AddLocation(dungeon_2, 2, 7);
            Dungeon_Final dungeon_final = new Dungeon_Final("Crypt");
            map.AddLocation(dungeon_final, 1, 8);

        }

        static void Start(ref Map map, ref Player player)
        {
            List<string> menuItems = new List<string>();
            int choice;

            // Refactored by Michiel and Alex
            do
            {
                Console.Clear();
                map.GetLocation().Description();
                Console.WriteLine();
                Console.WriteLine($"Max Health : {map.GetHealth()}\n");
                choice = ShowMenu(map, ref menuItems);

                if ( choice != menuItems.Count() )
                {
                    if ( validDirections.Contains( menuItems[choice] ) )
                    {
                        map.Move( menuItems[choice] );
                    }

                    switch ( menuItems[choice] )
                    {
                        case ACTION_SEARCH:
                            Console.Clear();
                            Console.WriteLine("you step into the dungeon, your vision fades as you feel like you are drowning..");
                            Console.WriteLine("once you regain your consciousness you are standing in a damp script ");
                            map.SetLocation(7, 3);
                            Console.ReadLine();
                            Console.Clear();
                            
                            break;

                        case ACTION_FIGHT:
                            map.BATTLE_SCNENE();
                            break;

                        case ACTION_RUN:
                            // Add code for running here
                        break;
                    }
                }
            } 
            // When the choice is equal to the total item it means exit has been chosen.
            while ( choice < menuItems.Count() - 1);
        }

        // This Method builds the menu
        static int ShowMenu(Map map, ref List<string> menu)
        {
            int choice;
            string input;

            menu.Clear();
            ShowDirections(map, ref menu);
            if (map.GetLocation().CheckForItems())
            {
                bool acquirableitems = false;
                Dictionary<string, Objects> list = map.GetLocation().GetItems();
                Objects[] obj = list.Values.ToArray();
                for (int i = 0; i < obj.Count(); i++)
                {
                    if (obj[i].GetAcquirable())
                        acquirableitems = true;
                }
                if(acquirableitems)
                    menu.Add( ACTION_SEARCH );
            }
            if (map.GetLocation().HasEnemy())
            {
                menu.Add( ACTION_FIGHT );
                menu.Add( ACTION_RUN );
            }
            menu.Add( ACTION_QUIT );

            do
            {
                for (int i = 0; i < menu.Count(); i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, menu[i]);
                }
                Console.WriteLine("Please enter your choice: 1 - {0}", menu.Count());
                input = Console.ReadLine();
            } while (!int.TryParse(input, out choice) || (choice > menu.Count() || choice < 0));

            //return choice;
            return ( choice - 1 );
        }

        static void ShowDirections(Map map, ref List<string> items)
        {
            map.AllowedDirections();

            if (map.GetNorth() == 1)
                items.Add( MOVE_NORTH );
            if (map.GetEast() == 1)
                items.Add( MOVE_EAST );
            if (map.GetSouth() == 1)
                items.Add( MOVE_SOUTH );
            if (map.GetWest() == 1)
                items.Add( MOVE_WEST );
        }

        static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing and have a nice day!");
            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }
    }
}