using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> type = new List<object>();
            type.Add(7);
            type.Add(28);
            type.Add(-1);
            type.Add(true);
            type.Add("chair");
            foreach (var entry in type){
                Console.WriteLine(entry);
            }
            }

        }
    }

