using System;
using System.Numerics;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line you are going to receive the count of the students – an integer number in the range[0…50]
            //•	On the second line you are going to receive the count of the lectures – an integer number in the range[0...50].
            //•	On the third line you are going to receive the initial bonus – an integer number in the range[0….100].
            //•	On the next lines, you will be receiving the attendances of each student.
            //•	There will never be students with equal bonuses.

            int numberOfStudent = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

            double maxAttendence = 0;
            int maxLectures = 0;
            double result = 0;

            for (int i = 1; i <= numberOfStudent; i++)
            {
                int attendancesStudent = int.Parse(Console.ReadLine());

                if (attendancesStudent > maxAttendence)
                {
                    maxAttendence = attendancesStudent;
                    maxLectures = attendancesStudent;
                }
                if (lectures > 0)
                {

                    result = (1.0 * maxAttendence / lectures) * (5 + additionalBonus);
                }
            }
            //maxAttendence *= 1000;
            //maxAttendence /= lectures;
            //double result = (double)maxAttendence;
            //result /= 1000;
            Console.WriteLine($"Max Bonus: {Math.Ceiling(result)}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
