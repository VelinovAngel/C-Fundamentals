using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add { number}: add a number to the end of the list.
            //Remove { number}: remove a number from the list.
            //Removeat { index}: remove a number at a given index.
            //Insert { number}{ index}: insert a number at a given index.


            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = input.Split();

                switch (splittedCommand[0])
                {
                    case "Add":
                        list.Add(int.Parse(splittedCommand[1]));
                        break;
                    case "Remove":

                            list.Remove(int.Parse(splittedCommand[1]));
                        break;
                    case "RemoveAt":
                            list.RemoveAt(int.Parse(splittedCommand[1]));                       
                        break;
                    case "Insert":
                            list.Insert(int.Parse(splittedCommand[2]), int.Parse(splittedCommand[1]));
                        break;
                }

            }
            Console.WriteLine(String.Join(" ", list));

        }
    }
}
