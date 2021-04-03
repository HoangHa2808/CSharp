using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap17
{
    class Planets
    {
        enum HanhTinh
        {
            Mercury = 1, Venus, Earth, Mars,
            Jupiter, Saturn, Urnus, Neptune
        }
        static void Main(string[] args)
        {
            string t = "Nhap so vi tri ban muon tim (1 -> 8): ";
            Console.Write(t);
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Vi tri {0} tuong ung voi {1}", h, (HanhTinh)h);
            Console.ReadKey();

        }
    }
}
