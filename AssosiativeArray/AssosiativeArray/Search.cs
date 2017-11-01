using System;
using System.Collections.Generic;
using System.Text;

namespace AssosiativeArray
{
    class Search
    {
        public void ArraySearch(string[,] arr, string val)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                for(var j = 0; j < 2; j++)
                {
                    if(arr[i,j].Contains(val))
                    {
                        Console.WriteLine(i[j]);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Key not found");
                    }
                }
                
            }
        }
    }
}
