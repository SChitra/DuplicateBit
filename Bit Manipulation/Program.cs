using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    /***Given an array that contains numbers from 1 to n-1 and exactly 1 duplicate, 
    find that duplicate using bit operations.***/
    //Time Complexity is O(n) as we are traversing through the list

    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 4 };
            //int[] arr = { 34, 12, 23, 45, 22, 67 };
            int[] arr = {25,20,34,33,56,34 };
            //int[] arr = { 0, 0, 1, 2 };

            int end = arr.Length;
         
            Console.WriteLine(BitManipulation(arr,end));
                     
            
        }

        public static int BitManipulation(int[] arr, int end)
        {
            for(int i =0; i <= end-1; i++)
            {
                for(int j = i+1; j <= end-1; j++)
                {
                    int x = arr[i] ^ arr[j];
                    if (x == 0)
                    {
                        return arr[i];
                    }
                 }
            }

            return -1;             
              
        }
    }
}
