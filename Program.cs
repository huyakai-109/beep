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
        static void BubbleSortVer3(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                count++;
                bool flag = false;
                for (int j = arr.Length - 1; j > i; j--)
                {
                   
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        flag = true;
                    }                    
                }
                if (flag == false)
                {
                    break;
                }
            }
            PrintArray(arr);
            Console.WriteLine("Count = " + count);
        
        }

        static void BubbleSortVer1(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                count++;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
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

            int[] arr1 = {1,2,3,4,5,6};
           
            BubbleSortVer3(arr1);
            BubbleSortVer1(arr1);
                 
            Console.ReadKey();
        }
    }
}

