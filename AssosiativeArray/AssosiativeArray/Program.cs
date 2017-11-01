using System;
using System.Collections;

namespace AssosiativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Outside = new string[,]
            {
                { "DIA", "Denver Internation Airport" },
                { "SEA", "Seattle Tacoma Internationl Airport" },
                { "LAX", "Los Angeles International Airport" }
            };
            Console.WriteLine("Please type a key");
            string get = Console.ReadLine().ToString();

            Search Search = new Search();
            Search.ArraySearch(Outside, get);

            Console.ReadKey();
            
            
        }
    }
}
