using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hearts = Console.ReadLine()
                 .Split('@', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int currIndex = 0;
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Love!")
            {
                //"Jump {length}". 

                string[] splittedCommand = command.Split();
                int jumpIndex = int.Parse(splittedCommand[1]);

                currIndex += jumpIndex;

                if (currIndex >= hearts.Length)
                {
                    currIndex = 0;
                }
                if (hearts[currIndex] == 0)
                {
                    Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                }
                else
                {
                    hearts[currIndex] -= 2;
                    if (hearts[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} has Valentine's day.");
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {currIndex}.");
            int cout = 0;
            foreach (var item in hearts)
            {
                if (item > 0)
                {
                    cout++;
                }
            }
            if (cout == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {cout} places.");
            }
        }
    }
}
