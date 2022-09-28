using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace demo
{
    internal class Program
    {
        static int[] DO = { 131, 262, 523, 1074 };
        static int[] DOs = { 139, 277, 540, 1109 };
        static int[] RE = { 147, 294, 587, 1175 };
        static int[] REs = { 156, 311, 622, 1245 };
        static int[] MI = { 165, 330, 659, 1319 };
        static int[] FA = { 175, 349, 698, 1397 };
        static int[] FAs = { 185, 370, 740, 1480 };
        static int[] SOL = { 196, 392, 784, 1568 };
        static int[] SOLs = { 208, 415, 831, 1661 };
        static int[] LA = { 220, 440, 880, 1760 };
        static int[] LAs = { 233, 466, 932, 1865 };
        static int[] SI = { 247, 494, 988, 1976 };
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            string[] cau1 = { "Làm", "gì", "có", "ai", "thương", "em", "như", "vậy" };
            int[] tanSo1 = { SOL[2], SOL[2], MI[3], RE[3], DO[3], DO[3], LA[2], SOL[2] };
            int[] khoangThoiGian1 = { 200, 200, 280, 200, 250, 400, 400, 400 };
            int[] thoiGianCho1 = {120, 80, 80, 80, 80, 300, 300, 300 };

            string[] cau2 = { "Có", "ai", "cần", "em", "đến", "thế" };
            int[] tanSo2 = { MI[3], RE[3], DO[3], RE[3], MI[3], SOL[3] };
            int[] khoangThoiGian2 = { 180, 180, 180, 300, 400, 500 };
            int[] thoiGianCho2 = { 120, 120, 120, 300, 300, 300 };

            string[] cau3 = { "Có", "ai", "chia", "tay", "mà", "vẫn", "mong", "từng", "ngày" };
            int[] tanSo3 = { MI[3], RE[3], DO[3], DO[3], LA[2], MI[3], RE[3], DO[3], DO[3] };
            int[] khoangThoiGian3 = { 150, 150, 150, 150, 160, 220, 120, 120, 120 };
            int[] thoiGianCho3 = { 150, 150, 150, 300, 150, 150, 150, 150, 400 };

            string[] cau4 = { "Mong", "niềm", "vui", "dù", "em", "thuộc", "về", "ai" };
            int[] tanSo4 = { SOL[2], MI[2], FA[2], MI[2], FA[2], MI[2], FA[2], SOL[2] };
            int[] khoangThoiGian4 = { 150, 150, 150, 150, 150, 150, 180, 150 };
            int[] thoiGianCho4 = { 180, 180, 220, 180, 180, 180, 180, 300 };

            Decoration();
            
            Console.SetCursorPosition(46, 6);
            Karaoke(cau1, tanSo1, khoangThoiGian1, thoiGianCho1, 6);
            Console.SetCursorPosition(46, 7);
            Karaoke(cau2, tanSo2, khoangThoiGian2, thoiGianCho2, 7);
            Console.SetCursorPosition(46, 8);
            Karaoke(cau3, tanSo3, khoangThoiGian3, thoiGianCho3, 8);
            Console.SetCursorPosition(46, 9);
            Karaoke(cau4, tanSo4, khoangThoiGian4, thoiGianCho4, 9);

            Console.ReadKey();


        }
        static void Decoration()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(45, i);
                for (int j = 0; j <= 10; j++)
                {
                    
                    if (i == 4 || j == 10 || i == 0 || j == 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(57, 1);
            Console.Write("KARAOKE");
            Console.SetCursorPosition(49, 2);
            Console.Write("Có ai thương em như anh");
            Console.SetCursorPosition(59, 3);
            Console.Write("Ca sĩ: Tóc Tiên");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(45, 5);
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    {

                        Console.Write(" ------");
                    }
                    else
                    {
                        Console.Write("------");
                    }
                }
                Console.SetCursorPosition(45, 7);
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(" ------");
                    }
                    else
                    {
                        Console.Write("------");
                    }
                }
                Console.SetCursorPosition(75, 6);
                Console.Write("|");
                Console.SetCursorPosition(45, 6);
                for (int i = 10; i >= 1; i--)
                {

                    if (i > 4)
                    {
                        if (i == 10)
                        {

                            Console.Write(" |");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("===");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("===");
                        }
                    }
                    else if (i < 4)
                    {
                        Console.Beep();
                        Console.Write(" " + i + " ");
                        if (i == 1)
                        {

                            Console.Write(" ");

                            Thread.Sleep(1000);
                        }
                    }
                    Thread.Sleep(500);

                }
                Console.Clear();
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(45, i);
                for (int j = 0; j <= 10; j++)
                {

                    if (i == 4 || j == 10 || i == 0 || j == 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(57, 1);
            Console.Write("KARAOKE");
            Console.SetCursorPosition(49, 2);
            Console.Write("Có ai thương em như anh");
            Console.SetCursorPosition(59, 3);
            Console.Write("Ca sĩ: Tóc Tiên");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(45, 5);

        }
        static void Karaoke(string[] loiBaiHat, int[] tanSo, int[] khoangThoiGian, int[] thoiGianCho, int dong)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string loi in loiBaiHat)
            {
                Console.Write("{0} ", loi);
            }
            int[] hz = tanSo;
            int[] duration = khoangThoiGian;
            int[] timeBreak = thoiGianCho;

            for (int i = 0; i < loiBaiHat.Length; i++)
            {
                int dem = 0;

                for (int z = 0; z <= i; z++)
                {
                    dem += loiBaiHat[z].Length;
                }
                dem += i;

                Console.SetCursorPosition(dem+46, dong);          
                for (int j = 0; j < loiBaiHat[i].Length; j++)
                {
                    Console.Write("\b");
                }
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write(loiBaiHat[i]);
                Console.Beep(hz[i], duration[i]);
                Thread.Sleep(timeBreak[i]+300);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
       
    }
}
