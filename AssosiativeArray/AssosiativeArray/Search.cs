using System;
using System.Collections.Generic;
using System.Text;

namespace AssosiativeArray
{
    class Search
    {
        public string ArraySearch(string[,] arr, string val)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                for(var j = 0; j < 2; j++)
                {
                    
                    if(arr[i,j].Contains(val))
                    {
                        string lol = $"Found it at {i}";
                        Print(lol);
                        
                    }
                    else
                    {
                        return("Key not found");
                    }
                }
                
            }
            return ("key unkown");
        }
        public void Print(string lol)
        {
            Console.WriteLine(lol);
        }
    }
}
