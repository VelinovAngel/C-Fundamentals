using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int battleWon = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleWon} won battles and {initialEnergy} energy");
                    return;
                }
                initialEnergy -= distance;
                battleWon++;
                if (battleWon % 3 == 0)
                {
                    initialEnergy += battleWon;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {battleWon}. Energy left: {initialEnergy}");
        }
    }
}
