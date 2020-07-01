using System;

namespace _0._1.National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGroupPeopleForHours = int.Parse(Console.ReadLine());
            int secondGroupPeopleForHours = int.Parse(Console.ReadLine());
            int thirtGroupPeopleForHours = int.Parse(Console.ReadLine());

            int peopleHelp = int.Parse(Console.ReadLine());

            int totalGroupPeopleForHours = firstGroupPeopleForHours + secondGroupPeopleForHours + thirtGroupPeopleForHours;

            int timeNeed = 0;

            while (peopleHelp > 0)
            {
                timeNeed++;
                if (timeNeed % 4 == 0)
                {
                    continue;
                }
                peopleHelp -= totalGroupPeopleForHours; 
            }
            Console.WriteLine($"Time needed: {timeNeed}h.");
        }
    }
}
