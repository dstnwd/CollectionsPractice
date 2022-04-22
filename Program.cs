using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zeroNine = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int i = 0; i < zeroNine.Length; i++)
            {
                Console.WriteLine("\n" + zeroNine[i]);
            }
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("\n" + names[i]);
            }
            bool[] trueFalse = new bool[] {true, false, true, false, true, false, true, false, true, false};
            for (int i = 0; i < trueFalse.Length; i++)
            {
                Console.WriteLine("\n" + trueFalse[i]);
            }
            List<string> iceCream = new List<string>();
            iceCream.Add("Cookie Dough");
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Rocky Road");

            Console.WriteLine("\n" + "5 Flavors of Ice Cream:");
            foreach (string cream in iceCream)
            {
                Console.WriteLine("-" + cream);
            }

            Console.WriteLine("\n" + $"There are {iceCream.Count} flavors of Ice Cream.");

            Console.WriteLine("\n" + $"The third value is {iceCream[2]}");

            iceCream.RemoveAt(2);
            Console.WriteLine("\n" + "Updated Flavors of Ice Cream are now...");
            foreach (string cream in iceCream)
            {
                Console.WriteLine("-" + cream);
            }

            Console.WriteLine("\n" + $"There are now {iceCream.Count} flavors of ice cream");

            Dictionary<string, string> newNames = new Dictionary<string, string>();
            for (int i = 0; i < names.Length; i++)
            {
                Random rand = new Random();
                newNames.Add(names[i], iceCream[rand.Next(0, 4)]);
            }
            foreach (var entry in newNames)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
