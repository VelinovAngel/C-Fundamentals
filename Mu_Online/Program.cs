using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            //rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 


            string[] rooms = Console.ReadLine().Split("|");
            int health = 100;
            int bitcoins = 0;
            bool isDead = false;
            int tempHealth = 0;
            int currHealt = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                int currBitcoins = 0;


                string[] splittedCommandType = rooms[i].Split();

                if (splittedCommandType[0] == "potion")
                {
                    tempHealth = health;
                    currHealt = health;
                    currHealt += int.Parse(splittedCommandType[1]);
                    if (currHealt <= 100)
                    {
                        health += int.Parse(splittedCommandType[1]);
                        Console.WriteLine($"You healed for {splittedCommandType[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                    }
                    else if (currHealt > 100)
                    {
                        int diff = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                    }

                }
                else if (splittedCommandType[0] == "chest")
                {
                    bitcoins += int.Parse(splittedCommandType[1]);
                    currBitcoins += int.Parse(splittedCommandType[1]);
                    Console.WriteLine($"You found {currBitcoins} bitcoins.");

                }
                else
                {
                    int attack = int.Parse(splittedCommandType[1]);
                    health -= attack;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {splittedCommandType[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isDead = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {splittedCommandType[0]}.");
                    }

                }
            }
            if (!isDead)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
