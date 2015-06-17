using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            string a = "", b = "", c = "", d = "", Num = "";
            for (int i = 1; i <= 4; i++)
            {
                if (a == "")
                    a = rnd.Next(0, 10).ToString();
                if (b == "")
                {
                    b = rnd.Next(0, 10).ToString();
                    while (b == a)
                        b = rnd.Next(0, 10).ToString();
                }
                if (c == "")
                {
                    c = rnd.Next(0, 10).ToString();
                    while (c == a || c == b)
                        c = rnd.Next(0, 10).ToString();
                }
                if (d == "")
                {
                    d = rnd.Next(0, 10).ToString();
                    while (d == a || d == b || d == c)
                        d = rnd.Next(0, 10).ToString();
                }
            }
            Num = a + b + c + d;
            Console.WriteLine("答案：" + Num);
            string GuessNum = "", Answers = "";
            while (GuessNum == "")
            {
                Console.Write("請輸入你要猜的四位數字：");
                GuessNum = Console.ReadLine();
                int SetCount = 0;             //位置A
                int NumberCount = 0;          //數字B
                if (int.Parse(a) == int.Parse(GuessNum) / 1000)
                    SetCount += 1;
                else if (int.Parse(a) == int.Parse(GuessNum) / 100 - (int.Parse(GuessNum) / 1000) * 10)
                    NumberCount += 1;
                else if (int.Parse(a) == (int.Parse(GuessNum) / 10) % 10)
                    NumberCount += 1;
                else if (int.Parse(a) == int.Parse(GuessNum) % 10)
                    NumberCount += 1;
                if (int.Parse(b) == int.Parse(GuessNum) / 1000)
                    NumberCount += 1;
                else if (int.Parse(b) == int.Parse(GuessNum) / 100 - (int.Parse(GuessNum) / 1000) * 10)
                    SetCount += 1;
                else if (int.Parse(b) == (int.Parse(GuessNum) / 10) % 10)
                    NumberCount += 1;
                else if (int.Parse(b) == int.Parse(GuessNum) % 10)
                    NumberCount += 1;
                if (int.Parse(c) == int.Parse(GuessNum) / 1000)
                    NumberCount += 1;
                else if (int.Parse(c) == int.Parse(GuessNum) / 100 - (int.Parse(GuessNum) / 1000) * 10)
                    NumberCount += 1;
                else if (int.Parse(c) == (int.Parse(GuessNum) / 10) % 10)
                    SetCount += 1;
                else if (int.Parse(c) == int.Parse(GuessNum) % 10)
                    NumberCount += 1;
                if (int.Parse(d) == int.Parse(GuessNum) / 1000)
                    NumberCount += 1;
                else if (int.Parse(d) == int.Parse(GuessNum) / 100 - (int.Parse(GuessNum) / 1000) * 10)
                    NumberCount += 1;
                else if (int.Parse(d) == (int.Parse(GuessNum) / 10) % 10)
                    NumberCount += 1;
                else if (int.Parse(d) == int.Parse(GuessNum) % 10)
                    SetCount += 1;
                GuessNum = "";
                Answers = SetCount + "A" + NumberCount + "B";
                Console.WriteLine("你猜的數字有：" + Answers);
                if (Answers == "4A0B")
                {
                    Console.WriteLine("恭喜你猜中數字：" + Num);
                    break;
                }
            }
        }
    }
}