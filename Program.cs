using System;
using System.Collections.Generic;
using System.Linq;


namespace PuzzleWork
{
    class Program
    {

        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] randomArray = new int[10];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(5, 25);
            }
            Console.WriteLine("The Min is: " + randomArray.Min());
            Console.WriteLine("The Max is: " + randomArray.Max());
            Console.WriteLine("The Sum is: " + randomArray.Sum());
            return randomArray;
        }

        public static string TossCoin()
        {
            Random rand = new Random();
            string final = "";
            int side = rand.Next(2);
            Console.WriteLine("Tossing a Coin!");

            if (side == 0)
            {
                final = "Heads";
                Console.WriteLine("Heads");
            }
            else
            {
                final = "Tails";
                Console.WriteLine("Tails");
            }

            return final;
        }

        public static double TossMultipleCoins(int num)
        {
            double final = 0;
            for (int i = 0; i < num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    final += 1;
                }
            }
            return (final / (double)num);
        }

        public static List<string> Name()
        {
            List<string> names = new List<string>();
            List<string> final = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            var shuffled = names.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (string first in names)
            {
                if (first.Length > 5)
                {
                    final.Add(first);
                }
            }

            return final;
        }

        static void Main(string[] args)
        {
            Name();
        }
    }
}
