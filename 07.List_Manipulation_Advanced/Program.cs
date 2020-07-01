using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _07.List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add { number}: add a number to the end of the list.
            //Remove { number}: remove a number from the list.
            //Removeat { index}: remove a number at a given index.
            //Insert { number}{ index}: insert a number at a given index.


            //Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
            //PrintEven – print all the even numbers, separated by a space.
            //PrintOdd – print all the odd numbers, separated by a space.
            //GetSum – print the sum of all the numbers.
            //Filter { condition} { number} – print all the numbers that fulfill the given condition.
            //The condition will be either '<', '>', ">=", "<=".

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            bool isChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = input.Split();

                switch (splittedCommand[0])
                {
                    case "Add":
                        list.Add(int.Parse(splittedCommand[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        list.Remove(int.Parse(splittedCommand[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(splittedCommand[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        list.Insert(int.Parse(splittedCommand[2]), int.Parse(splittedCommand[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        if (list.Contains(int.Parse(splittedCommand[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        int sum = 0;
                        sum = list.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (splittedCommand[1])
                        {
                            case "<":
                                List<int> smallThem = new List<int>();

                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (int.Parse(splittedCommand[2]) > list[i])
                                    {
                                        smallThem.Add(list[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(' ', smallThem));
                                break;
                            case ">":
                                List<int> bigThem = new List<int>();

                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (int.Parse(splittedCommand[2]) < list[i])
                                    {
                                        bigThem.Add(list[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(' ', bigThem));
                                break;
                            case ">=":
                                List<int> bigThemAndUgual = new List<int>();

                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (int.Parse(splittedCommand[2]) <= list[i])
                                    {
                                        bigThemAndUgual.Add(list[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(' ', bigThemAndUgual));
                                break;
                            case "<=":
                                List<int> smallThemUgual = new List<int>();

                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (int.Parse(splittedCommand[2]) >= list[i])
                                    {
                                        smallThemUgual.Add(list[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(' ', smallThemUgual));
                                break;
                        }
                        break;
                }
            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }

        static void PrintEven(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(String.Join(' ', evenNumbers));
        }
        static void PrintOdd(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(String.Join(' ', oddNumbers));
        }


    }
}
