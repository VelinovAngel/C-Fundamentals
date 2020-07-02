using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int mounth = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double percentage = journeyCost * 0.25;

            //25% of journeyCost  = 


            for (int i = 1; i <= mounth; i++)
            {
                double bonus = savedMoney * 0.25;
                if (i % 4 == 0)
                {
                    savedMoney += bonus;
                }
                if (i % 2 == 1 && i >= 2)
                {
                    savedMoney -= (savedMoney * 0.16);
                }
                savedMoney += percentage;
            }
            if (savedMoney >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {savedMoney - journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost - savedMoney:f2}lv. more.");
            }
        }

    }
}
