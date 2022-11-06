using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            
            
                int temp = a;
                a = b;
                b = temp;
            
        }
        static void BubbleSortVer1(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                bool flag = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                   
                    if (arr[j] > arr[j + 1])
                    {
                       
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = true;
                    }
                }
                if(flag == false)
                {
                    break;
                }
            }
            PrintArray(arr);
            Console.WriteLine("Count = " + count);
        }
        static void BubbleSortVer2(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    
                    if (arr[j] > arr[j + 1])
                    {
                       
                        Swap(ref arr[j], ref arr[j + 1]);
                        
                    }
                }
              
            }
           PrintArray(arr);
            Console.WriteLine("Count = " + count);
        }
        
        static void PrintArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] arr1 = { 2,9,7,1,100,98,-6};
           
            BubbleSortVer1(arr1);
            BubbleSortVer2(arr1);
         

          
            Console.ReadKey();
        }
    }
}

