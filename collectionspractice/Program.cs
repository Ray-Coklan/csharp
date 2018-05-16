using System;
using System.Collections.Generic;

namespace collectionspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] arr = {1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(arr[0]);
            // string[] names = new string[4] {"tim", "sara", "martin", "nikki"};
            // Console.WriteLine("i am friends with {1}", names);
            // int [,] multTable = new int[10,10];
            // for(int i = 1; i <= 10; i++){
            //     for (int j = 1; j<= 10; j++){
            //         multTable[i -1, j-1] = i * j;
            //     }
            // }
        // List<string> flavors = new List<string>();
        // flavors.Add("vanilla");
        // flavors.Add("chocolate");
        // flavors.Add("mint");
        // Console.WriteLine("list is {0} ", flavors.Count);
        Dictionary<string,string> profile = new Dictionary<string,string>();
        profile.Add("name","tim");
        profile.Add("favorite flavor", "chocolate");
        Console.WriteLine("name" + profile["name"]);
        }
        
    }
}
