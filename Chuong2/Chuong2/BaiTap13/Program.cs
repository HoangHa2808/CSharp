using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap13
{
    class MakeChange
    {
        static void Main(string[] args)
        {
            int Twenties, Tens, Fires, Ones;
            int Dollar, Dollar1, Dollar2;

            int SoDollar;
            Console.Write("Nhap so tien can doi : $");
            SoDollar = int.Parse(Console.ReadLine());

            Twenties = SoDollar / 20;
            Dollar = SoDollar % 20;
            Tens = Dollar / 10;
            Dollar1 = Dollar % 10;
            Fires = Dollar1 / 5;
            Dollar2 = Dollar1 % 5;
            Ones = Dollar2 / 1;

            Console.WriteLine(" {0} doi thanh {1} to $20, {2} to $10, {3} to $5, {4} to $1", SoDollar,Twenties,Tens,Fires,Ones);
            Console.ReadKey();
        }
    }
}
