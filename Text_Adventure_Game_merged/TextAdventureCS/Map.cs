using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Map
    {
        private int height;
        private int width;
        private Location[,] map;

        private Position pos;
        private Directions directions;

        private struct Position
        {
            public int Xposition;
            public int Yposition;
        }

        private struct Directions
        {
            public int north;
            public int east;
            public int south;
            public int west;
        }

        public Map(int width, int height, int XStartPos, int YStartPos)
        {
            this.width = width;
            this.height = height;

            map = new Location[this.width, this.height];
            directions = new Directions();
            
            if ((XStartPos < width) && (XStartPos >= 0) && (YStartPos < height) && (YStartPos >= 0))
            {
                pos = new Position() { Xposition = XStartPos, Yposition = YStartPos };
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error: Position is outside the map");
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
            }
        }

        public void AddLocation(Location loc, int XPos, int YPos)
        {
            map[XPos, YPos] = loc;
        }

        public void Move(string dir)
        {
            switch (dir)
            {
                case "Go North":
                    pos.Yposition -= 1;
                    break;
                case "Go East":
                    pos.Xposition += 1;
                    break;
                case "Go South":
                    pos.Yposition += 1;
                    break;
                case "Go West":
                    pos.Xposition -= 1;
                    break;
                default:
                    Console.WriteLine("Move() has broken down.");
                    break;
            }
        }

        public void AllowedDirections()
        {
            // if a direction has a value of 1, then the player can go there
            directions.north = 1;
            directions.east = 1;
            directions.south = 1;
            directions.west = 1;

            // Check boundries and if there is a level north in the array
            if (pos.Yposition - 1 < 0)
                directions.north = -1;
            else if (map[pos.Yposition - 1, pos.Xposition] == null)
                directions.north = -1;
            // Check boundries and if there is a level south in the array
            if (pos.Yposition + 1 >= height)
                directions.south = -1;
            else if (map[pos.Yposition + 1, pos.Xposition] == null)
                directions.south = -1;
            // Check boundries and if there is a level east in the array
            if (pos.Xposition + 1 >= width)
                directions.east = -1;
            else if (map[pos.Yposition, pos.Xposition + 1] == null)
                directions.east = -1;
            // Check boundries and if there is a level west in the array
            if (pos.Xposition - 1 < 0)
                directions.west = -1;
            else if (map[pos.Yposition, pos.Xposition - 1] == null)
                directions.west = -1;
        }

        public Location GetLocation()
        {
            return map[pos.Yposition,pos.Xposition];
        }

        public int GetNorth()
        {
            return directions.north;
        }

        public int GetEast()
        {
            return directions.east;
        }

        public int GetSouth()
        {
            return directions.south;
        }

        public void SetLocation(int X, int Y)
        {
            pos.Xposition = X;
            pos.Yposition = Y;
        }
        public int GetHealth()
        {
            return maxHealth;
        }
        public int GetWest()
        {
            return directions.west;
        }
        bool Artifact = false;
        int bonusDmg = 0;
        int maxHealth = 100;
        private int EnemyHealth;
        public void BATTLE_SCNENE()
        {
            string enemyName = "Enemy";
            int minAtk = 1;
            int maxAtk = 10;
            string CurrLocation = $"{GetLocation()}";

            if (CurrLocation == "TextAdventureCS.Plains")
            {
                EnemyHealth = 80;
                enemyName = "Grassland Creature";
                minAtk = 1;
                maxAtk = 8;
            }
            if (CurrLocation == "TextAdventureCS.Plains")
            {
                EnemyHealth = 100;
                enemyName = "Forrest Creature";
                minAtk = 1;
                maxAtk = 10;
            }
            if (CurrLocation == "TextAdventureCS.Church")
            {
                EnemyHealth = 120;
                enemyName = "Raven Knight Defector";
                minAtk = 1;
                maxAtk = 12;
            }
            if (CurrLocation == "TextAdventureCS.Dungeon_1")
            {
                EnemyHealth = 100;
                enemyName = "Skeleton";
                minAtk = 6;
                maxAtk = 17;
            }
            if (CurrLocation == "TextAdventureCS.Dungeon_2")
            {
                EnemyHealth = 120;
                enemyName = "Animated Armor";
                minAtk = 3;
                maxAtk = 15;
            }
            if (CurrLocation == "TextAdventureCS.Dungeon_Final")
            {
                EnemyHealth = 300;
                enemyName = "Manifestation of Taint";
                minAtk = 7;
                maxAtk = 25;
            }

            int magic = 100;
            int health = maxHealth; 
            Console.Clear();
            Console.WriteLine("         Enemy Epproaching\n\n");
            System.Threading.Thread.Sleep(900);
            Console.Clear();
            Random Chance = new Random();
            int Drop = (Chance.Next(1, 8));
            Random Enemy = new Random();
            int EnemyAttack = (Enemy.Next(minAtk, maxAtk));

            do
            {
                Console.WriteLine("         Battle\n\n");
                Console.WriteLine("{1} Health = {0}", EnemyHealth, enemyName);
                if (health < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Health = {0}\n\n", health);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Your Health = {0}\n\n", health);
                }
                if (magic >= 100)
                {
                    Console.WriteLine("Magic : {*****}\n");
                }
                else if (magic >= 80)
                {
                    Console.WriteLine("Magic : {***** }\n");
                }
                else if (magic >= 60)
                {
                    Console.WriteLine("Magic : {***  }\n");
                }
                else if (magic >= 40)
                {
                    Console.WriteLine("Magic : {**   }\n");
                }
                else if (magic >= 20)
                {
                    Console.WriteLine("Magic : {*    }\n");
                }
                else if (magic >= 0 | magic <= 0)
                {
                    Console.WriteLine("Magic : {     }\n");
                }

                Console.WriteLine("-=-=-= Moves =-=-=-\n");
                Console.WriteLine("1 Sword Attack");
                Console.WriteLine("2 Heal");
                Console.WriteLine("3 Block");
                Console.WriteLine("4 Run\n\n");
                
                String AttackChoice = Console.ReadLine();
                if (AttackChoice == "1")
                {
                    Random rnd = new Random();
                    int AttackDMG = (rnd.Next(1, 14)+bonusDmg);
                    EnemyHealth = EnemyHealth - AttackDMG;
                    Console.Clear();
                    health = health - EnemyAttack;
                    Console.Clear();
                }
                else if (AttackChoice == "2")
                {
                    if (magic >= 20 & health < maxHealth)
                    {
                        magic -= 10;
                        health += 20;
                        Console.Clear();
                        health = health - EnemyAttack;
                        Console.Clear();
                    }

                    else if (magic <= 20)
                    {
                        Console.WriteLine("You cant heal yourself again\n");
                        Console.WriteLine("Check Your Magic");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (health >= maxHealth)
                    {
                        Console.WriteLine("You cant heal yourself again\n");
                        Console.WriteLine("You are already Full hp");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }



                
                else if (AttackChoice == "3")
                {
                    Console.WriteLine("Attack Blocked");
                    Console.Clear();
                }
                else if (AttackChoice == "4")
                {
                    health = 0;
                }
                else
                {
                    Console.WriteLine("Choose a move above.");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (CurrLocation == "TextAdventureCS.Dungeon_Final" && EnemyHealth <0)
                {
                    Console.WriteLine("You have Defeaten the Boss\n");
                    Console.WriteLine("Thank You for playing this game.");
                    Console.ReadLine();
                }
                if (CurrLocation == "TextAdventureCS.Church" && EnemyHealth < 0)
                {
                    //church boss defeated
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
                    Console.WriteLine("As you showed what you found to the other knights, you all headed back to base.");
                    Console.ReadLine();
                    Console.Clear();

                    Artifact = true;
                }
                if (EnemyHealth < 0)
                {
                    Console.Clear();
                    Console.WriteLine("The enemy was slain.");
                    
                    Console.ReadLine();
                    if (Drop == 3)
                    {
                        Console.WriteLine("You feel a power surging from within, you have gotten stronger!");
                        bonusDmg +=2;
                        Console.ReadLine();
                    }
                    if (Drop == 2)
                    {
                        Console.WriteLine("You feel a power surging from within, you feel more healthy!");
                        maxHealth += 10;
                        Console.ReadLine();
                    }
                }
                if (health < 0)
                {
                    Console.Clear();
                    Console.WriteLine(@"
                      _____        __           _             
                     |  __ \      / _|         | |            
                     | |  | | ___| |_ ___  __ _| |_ ___ _ __  
                     | |  | |/ _ \  _/ _ \/ _` | __/ _ \ '_ \ 
                     | |__| |  __/ ||  __/ (_| | ||  __/ | | |
                     |_____/ \___|_| \___|\__,_|\__\___|_| |_|
                     
                                          
                    ");
                    maxHealth = 100;
                    Console.ReadLine();
                }


            } while (EnemyHealth > 0 & health > 0);
        }
    }
}
