using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            int[] thoiGianCho1 = { 120, 80, 80, 80, 80, 300, 300, 300 };

            string[] cau2 = { "Có", "ai", "cần", "em", "đến", "thế" };
            int[] tanSo2 = { MI[3], RE[3], DO[3], RE[3], MI[3], SOL[3] };
            int[] khoangThoiGian2 = { 180, 180, 180, 300, 400, 500 };
            int[] thoiGianCho2 = { 120, 120, 120, 300, 290, 300 };

            string[] cau3 = { "Có", "ai", "chia", "tay", "mà", "vẫn", "mong", "từng", "ngày" };
            int[] tanSo3 = { MI[3], RE[3], DO[3], DO[3], LA[2], MI[3], RE[3], DO[3], DO[3] };
            int[] khoangThoiGian3 = { 150, 150, 150, 150, 160, 220, 120, 120, 120 };
            int[] thoiGianCho3 = { 150, 150, 150, 300, 150, 150, 150, 150, 400 };

            string[] cau4 = { "Mong", "niềm", "vui", "dù", "em", "thuộc", "về", "ai" };
            int[] tanSo4 = { SOL[2], MI[2], FA[2], MI[2], FA[2], MI[2], FA[2], SOL[2] };
            int[] khoangThoiGian4 = { 150, 150, 150, 150, 150, 150, 180, 150 };
            int[] thoiGianCho4 = { 180, 180, 220, 180, 180, 180, 180, 300 };

            khung();
            thanhDemNguoc();
            Console.Clear();
            khung();

            //Console.SetCursorPosition(46, 5);
            //Karaoke(cau1, tanSo1, khoangThoiGian1, thoiGianCho1, 5);
            //Console.SetCursorPosition(46, 6);
            //Karaoke(cau2, tanSo2, khoangThoiGian2, thoiGianCho2, 6);
            //Console.SetCursorPosition(46, 7);
            //Karaoke(cau3, tanSo3, khoangThoiGian3, thoiGianCho3, 7);
            //Console.SetCursorPosition(46, 8);
            //Karaoke(cau4, tanSo4, khoangThoiGian4, thoiGianCho4, 8);

            Console.ReadKey();
        }
        static void Karaoke(string[] loiBaiHat, int[] tanSo, int[] khoangThoiGian, int[] thoiGianCho, int dong)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string loi in loiBaiHat)
            {
                Console.Write("{0} ", loi);
            }

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
                Console.Beep(tanSo[i], khoangThoiGian[i]);
                Thread.Sleep(thoiGianCho[i]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }       
        static void khung()
        {
           
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(45, i);
                for (int j = 0; j <= 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (i == 4 || j == 10 || i == 0 || j == 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }             
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(57, 1);
            Console.Write("KARAOKE");
            Console.SetCursorPosition(49, 2);
            Console.Write("Có ai thương em như anh");
            Console.SetCursorPosition(59, 3);
            Console.Write("Ca sĩ: Tóc Tiên");
        }
        static void thanhDemNguoc()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(45, 5);
            Console.Write(" -------------------------------");
            Console.SetCursorPosition(45, 7);
            Console.Write(" -------------------------------");
            Console.SetCursorPosition(76, 6);
            Console.Write("|");
            Console.SetCursorPosition(45, 6);
            Console.Write(" |");
            for (int i = 9; i >= 1; i--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i == 1)
                {
                    Console.SetCursorPosition(71, 6);
                    Console.Write("=====");
                    Console.SetCursorPosition(61, 6);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("1");
                    Console.Beep();
                    Thread.Sleep(100);
                }
                else
                {
                    Console.Write("===");
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(61, 6);
                    Console.Write("2");
                    Console.Beep();
                    Thread.Sleep(50);
                    Console.SetCursorPosition(70, 6);

                }
                if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(61, 6);
                    Console.Write("3");
                    Console.Beep();
                    Thread.Sleep(200);
                    Console.SetCursorPosition(68, 6);

                }

            }
             Thread.Sleep(800);
            
        }
        
    }
}
