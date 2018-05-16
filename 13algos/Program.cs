using System;
using System.Collections.Generic;


namespace _13algos
{
    public class Program
    {
        static void Main(string[] args)
        {
        //    Print1_255();
        //    PrintOdd1_255();
        // PrintSum();
        // iterateArr (new int[] {1,3,5,7,9});
        // findMax (new int[] {1,5,7,9});
        // findAvg (new int[] {1,1,1,1});
        // negArr ();
        // greaterThanY(new int[] {1,2,3,4}, 3);
        // squareVals(new int[] {2,4,5});
        // replaceNegVals(new int[] {2,4,-1,5});
        // numToString(new int[] {1,-2,3,4});
        }
        public static void Print1_255(){
            int i = 0;
            while(i < 256){
                Console.WriteLine(i);
                i++;
            }
        }
        public static void PrintOdd1_255(){
            int i = 0;
            while(i < 256){
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(var i=1; i < 256; i++){
                sum += i;
                Console.WriteLine(sum);
            }

        }
        public static void iterateArr(int [] Array){
            int sum = 0;
            for(var i = 0; i < Array.Length; i++){
                sum = Array[i];
                Console.WriteLine(sum);
            }
        }   
        public static void findMax(int[] Array){
            var max = Array[0];
            for(int i = 0; i < Array.Length; i++){
                if(max > Array[i]){
                    max = Array[i];
                    Console.WriteLine(max);
                }
            }
        }
        public static void findAvg(int[] Array){
            int sum = 0;
            for(int i = 0; i < Array.Length; i++){
                sum = sum + Array[i];
            }
            Console.WriteLine(sum/Array.Length); 
        }
        public static void negArr(){
            List<int> negatives = new List<int>();
            for(var i = 1; i < 256; i++){
                if(i % 2 != 0){
                    negatives.Add(i);
                }
            }
        Console.WriteLine(negatives);
        }
        public static void greaterThanY(int[] Array, int Y){
            int count = 0;
            for(int i = 0; i < Array.Length; i++){
                if( Array[i] > Y){
                    count ++;
                }
            }
        Console.WriteLine(count);
        }
        public static void squareVals(int[] Array){
            for(int i = 0; i < Array.Length; i++){
                Array[i] = Array[i] * Array[i];
            }
        Console.WriteLine(Array[2]);
        }
        public static void replaceNegVals(int[] Array){
            for(int i = 0; i < Array.Length; i++){
                if(Array[i] < 0){
                    Array[i] = 0;
                }
            }
            Console.WriteLine(string.Join(",", Array));
        }
        public static object numToString(object[] arr){
            for(int idx = 0; idx < arr.Length; idx++){
                if((int)arr[idx] < 0){
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }
        public static void ShiftLeft(int[] arr){
            for(int idx = 0; idx<arr.Length - 1; idx++){
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length - 1] = 0;
        }
    }
}
