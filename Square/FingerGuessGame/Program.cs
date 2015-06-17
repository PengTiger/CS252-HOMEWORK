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
            Console.WriteLine("剪刀：1，石頭：2，布：3，猜拳比賽開始");
            Console.Write("請輸入幾人要猜拳：");
            int People = int.Parse(Console.ReadLine());
            Random random = new Random();
            int a = random.Next(1, 4);
            Console.Write(a);
        }
    }
}