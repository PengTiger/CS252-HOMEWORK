using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerGuessGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random FingerGuess = new Random();
            string Player, Paper, Scissors, Stone;
            Player = "";
            Paper = "";
            Scissors = "";
            Stone = "";
            Console.Write("請輸入要幾個人猜拳：");
            int People = int.Parse(Console.ReadLine());
            for (int i = 1; i <= People; i++)
            {
                int j = FingerGuess.Next(1, 4);
                switch (j)
                {
                    case 1:
                        Player += "剪刀：" + i.ToString() + ",";
                        Scissors += i.ToString() + ","; ;
                        break;

                    case 2:
                        Player += "石頭：" + i.ToString() + ",";
                        Stone += i.ToString() + ",";
                        break;

                    case 3:
                        Player += "布：" + i.ToString() + ",";
                        Paper += i.ToString() + ",";
                        break;
                }
            }
            Console.WriteLine("猜拳明細：" + Player);
            if (Paper == "")
                Console.WriteLine("此盤為石頭獲勝，獲勝者為：" + Stone);
            else if (Scissors == "")
                Console.WriteLine("此盤為布獲勝，獲勝者為：" + Paper);
            else if (Stone == "")
                Console.WriteLine("此盤為剪刀獲勝，獲勝者為：" + Scissors);
            else
                Console.WriteLine("此盤合局！！！");
        }
    }
}