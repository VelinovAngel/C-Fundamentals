using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Add Book | { book name} Add a book at first place in the shelf. 
            //o If the book already is present on the shelf, ignore the command.

            //•	Take Book | { book name} Remove the book with the given name only if the book is on the shelf, otherwise ignore this command.

            //•	Swap Books | { book1} | { book2} If both books are on the shelf, swap their places.

            //•	Insert Book | { book name}  Add a book at the end of the book collection.

            //•	Check Book | { index}Print the name of the book on the given index the book.
            //o If the index is invalid, ignore the command.

            List<string> listBooks = Console.ReadLine().Split('&').ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commandSplitted = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                switch (commandSplitted[0])
                {
                    case "Add Book":
                        if (!listBooks.Contains(commandSplitted[1]))
                        {
                            listBooks.Insert(0, commandSplitted[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Take Book":
                        if (listBooks.Contains(commandSplitted[1]))
                        {
                            listBooks.RemoveAll(x => x == commandSplitted[1]);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Swap Books":
                        string temp = string.Empty;
                        if (listBooks.Contains(commandSplitted[1]) && listBooks.Contains(commandSplitted[2]))
                        {
                            //Use this logic to swap 2 elements
                            //T tmp = list[indexA];
                            //list[indexA] = list[indexB];
                            //list[indexB] = tmp;
                            int indexA = listBooks.IndexOf(commandSplitted[1]);
                            int indexB = listBooks.IndexOf(commandSplitted[2]);
                            temp = listBooks[indexA];
                            listBooks[indexA] = listBooks[indexB];
                            listBooks[indexB] = temp;
                        }
                        break;
                    case "Insert Book":
                        listBooks.Add(commandSplitted[1]);
                        break;
                    case "Check Book":
                        if (int.Parse(commandSplitted[1]) >= 0 && int.Parse(commandSplitted[1]) < listBooks.Count)
                        {
                            Console.WriteLine($"{listBooks[int.Parse(commandSplitted[1])]}");
                        }
                        else
                        {
                            continue;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", listBooks));
        }
    }
}
