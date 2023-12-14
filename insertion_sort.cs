using System;
using System.Collections.Generic;

namespace ta1
{
    class Program
    {
    void sort(int[] array) 
    { 
        int i,j;
        for (i = 1; i < array.Length; i++) { 
            j = i-1;  
            int value = array[i];
            
            while (j >= 0 && array[j] > value) { 
                array[j + 1] = array[j]; 
                j--;  
            } 
            
            array[j+1] = value;
            if(value != array[i])
            {
                print(array);
            }  
        } 
    } 
    static void print(int[] arr) 
    { 
        for (int i = 0; i < arr.Length; ++i) 
            Console.Write(arr[i] + " "); 
  
        Console.Write("\n"); 
    }
        static void Main(string[] args)
        {
            
            string s = Console.ReadLine();
            string[] snums= s.Split(' ');
            int[] num = new int[snums.Length-1];
            for(int i=0;i<snums.Length-1;i++)
            {
               num[i]=Convert.ToInt32(snums[i]);
            }
            Program ob = new Program(); 
            ob.sort(num); 
            
        }
    }
}
