using System;
using System.Linq;

namespace _0._6.Middle_Characters_Into_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            PrintMiddleChar(array);
        }

        static void PrintMiddleChar(string array)
        {
            if (array.Length % 2 != 0)
            {
                for (int i = array.Length / 2; i < (array.Length / 2) + 1; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else 
            {
                for (int i = (array.Length / 2) - 1; i < (array.Length / 2) + 1; i++)
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}
