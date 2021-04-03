using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap16
{
    class MonthNames
    {
        enum Month
        {
            January = 1, February, March, April, May, June,
            July, August, September, October, November, December
        }
        static void Main(string[] args)
        {
            string t = "Nhap mot so bat ky tu 1 -> 12 : ";
            Console.Write(t);
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Vay so {0} tuong ung voi {1}", h, (Month)h);
            Console.ReadKey();
        }
    }
}
