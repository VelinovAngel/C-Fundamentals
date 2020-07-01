using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console
                .ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //•	"Collect - {item}" – Receiving this command, you should add the given item in your inventory. If the item already exists, you should skip this line.
            //•	"Drop - {item}" – You should remove the item from your inventory, if it exists.
            //•	"Combine Items - {oldItem}:{newItem}" – You should check if the old item exists, if so, add the new item after the old one. Otherwise, ignore the command.
            //•	"Renew – {item}" – If the given item exists, you should change its position and put it last in your inventory.

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] splittedCommand = command.Split(new char[] { '-', ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommand[0] == "Collect")
                {
                    if (!lists.Contains(splittedCommand[1]))
                    {
                        lists.Add(splittedCommand[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (splittedCommand[0] == "Drop")
                {
                    if (lists.Contains(splittedCommand[1]))
                    {
                        lists.Remove(splittedCommand[1]);
                    }
                }
                else if (splittedCommand[0] == "Combine" && splittedCommand[1] == "Items")
                {
                    string[] items = splittedCommand[2].Split(new char[] { ':', ' ' }
               , StringSplitOptions.RemoveEmptyEntries);
                    string oldItems = items[0];
                    string newItems = items[1];

                    if (lists.Contains(items[0]))
                    {

                        lists.Insert(lists.IndexOf(oldItems) + 1, newItems);
                    }

                }
                else if (splittedCommand[0] == "Renew")
                {
                    if (lists.Contains(splittedCommand[1]))
                    {

                        lists.RemoveAt(lists.IndexOf(splittedCommand[1]));
                        lists.Add(splittedCommand[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", lists));
        }
    }
}
