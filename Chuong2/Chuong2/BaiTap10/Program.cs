using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTap10
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            int a = 206;
            int phut  = 60;
            int gio = 0;
            gio = a / phut;
            phut = a % phut;
            Console.WriteLine("Doi : {0} phut thanh {1} gio va {2} phut ", a, gio, phut);
            Console.ReadKey();


        }
    }
}
