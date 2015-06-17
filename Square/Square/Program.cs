using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入你需要幾個X當正方形的邊長：");
            int SideLength = int.Parse(Console.ReadLine());
            for (int i = 1; i <= SideLength; i++)
            {
                for (int j = 1; j <= SideLength; j++)
                {
                    if (j > SideLength)
                        break;
                    else
                        Console.Write("X");
                }
                Console.WriteLine("");
            }
        }
    }
}