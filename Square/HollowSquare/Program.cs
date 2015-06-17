using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollowSquare
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入你要邊長為多少的空心正方形：");
            int SideLength = int.Parse(Console.ReadLine());
            for (int i = 1; i <= SideLength; i++)
            {
                if (i == 1 || i == SideLength)
                {
                    for (int j = 1; j <= SideLength; j++)
                        Console.Write("*");
                }
                else
                {
                    string SideWidth = "*";
                    string Blank = "";
                    for (int k = 2; k <= SideLength - 1; k++)
                        Blank = Blank + " ";
                    SideWidth = SideWidth + Blank + "*";
                    Console.Write(SideWidth);
                }
                Console.WriteLine("");
            }
        }
    }
}