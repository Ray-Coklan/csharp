using System;

namespace fund
{
    class Program
    {
        static void Main(string[] args)
        {
            //  for(int i =1; i < 256; i++)
            //  Console.WriteLine(i);

            //  for(int i=1; i <1001; i++)
            //  if (i % 3 ==0 || i % 5 ==0)
            //  Console.WriteLine(i);
            for(int i = 1; i < 10; i ++)
            if (i % 3 == 0){
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0){
                Console.WriteLine("buzz");
            }
            else if ( i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("fizzbuzz");
            }
            }
        } 
           
            
    }
    

