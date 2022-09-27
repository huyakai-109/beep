using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace demo
{
    internal class Program
    {
        static int[] DO = {131, 262, 523, 1074};
        static int[] RE = { 147, 294, 587, 1175};
        static int[] MI = { 165, 330, 659, 1319};
        static int[] FA = { 175, 349, 698, 1397};
        static int[] SOL = { 196, 392, 784, 1568};
        static int[] LA = { 220, 440, 880, 1760};
        static int[] SI = { 247, 494, 988, 1976};
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] a = loi();
            int[] hz = tanSo();
            int[] duration = khoangThoiGian();
            int[] timeBreak = cho();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(a[i]);
                Console.Beep(hz[i], duration[i]);
                Thread.Sleep(timeBreak[i]);
            }
            Console.ReadKey();
           
        }
        static string[] loi()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string filePath = @"D:\Kho\laptrinh.txt";
            string[] lines = { };
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            //string[] lines = { "Con", "cò", "bé", "bé", "nó", "đậu", "cành", "tre", };
            return lines;
        }
        static int[] tanSo()
        {
            int[] a = { DO[2], SOL[1], FA[2], FA[2], FA[2], LA[1], DO[2], RE[2] };
            return a;
        }
        static int[] khoangThoiGian()
        {
            int[] a = { 200, 200, 400, 700, 200, 300, 200, 200 };
            return a;
        }
        static int[] cho()
        {
            int[] a = { 200, 200, 200, 650, 200, 200, 200, 200 };
            return a;
        }
    }
}
