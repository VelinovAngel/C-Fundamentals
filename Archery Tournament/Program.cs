using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //•"Shoot Left@{start index}@{length}":Iskren starts traversing the archery field to the left from { start index} with given { length}.If he goes out of the field, he will continue from the end of the field.
            //•"Shoot Right@{start index}@{length}":Iskren starts traversing the archery field to the right from { start index}with given { length}.If he goes out of the field, he will continue from the start of the field.
            //•"Reverse":Reverse the archery field.
            //•	"Game Over"
            //Print the archery field and collected points.

            List<int> list = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            string input = string.Empty;
            int power = 5;
            int sumPoint = 0;

            while ((input = Console.ReadLine()) != "Game over")
            {
                string[] commandSplitted = input.Split('@', StringSplitOptions.RemoveEmptyEntries);

                switch (commandSplitted[0])
                {
                    case "Shoot Left":
                        int startIndexLeft = int.Parse(commandSplitted[1]);
                        int lenghtLeft = int.Parse(commandSplitted[2]);
                        if (startIndexLeft >= 0 && startIndexLeft < list.Count)
                        {
                            int targetIndexLeft = startIndexLeft - lenghtLeft;
                            while (targetIndexLeft < 0)
                            {
                                targetIndexLeft = list.Count + targetIndexLeft;
                            }
                            if (list[targetIndexLeft] >= power)
                            {
                                list[targetIndexLeft] -= power;
                                sumPoint += power;
                            }
                            else
                            {
                                sumPoint += list[targetIndexLeft];
                                list[targetIndexLeft] = 0;
                            }
                        }
                        break;

                    case "Shoot Right":
                        int startIndexRight = int.Parse(commandSplitted[1]);
                        int lenghtRight = int.Parse(commandSplitted[2]);
                        if (startIndexRight >= 0 && startIndexRight < list.Count)
                        {
                            int targetIndexRight = startIndexRight + lenghtRight;
                            while (targetIndexRight >= list.Count)
                            {
                                targetIndexRight -= list.Count;
                            }
                            if (list[targetIndexRight] >= power)
                            {
                                list[targetIndexRight] -= power;
                                sumPoint += power;
                            }
                            else
                            {
                                sumPoint += list[targetIndexRight];
                                list[targetIndexRight] = 0;
                            }
                        }
                        break;

                    case "Reverse":
                        list.Reverse();
                        break;
                }

            }
            Console.WriteLine(string.Join(" - ", list));
            Console.WriteLine($"Iskren finished the archery tournament with {sumPoint} points!");
        }
    }
}
