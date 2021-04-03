using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTap7
{
    class ProjectedRaises
    {
        static void Main(string[] args)
        {
            const float h = 0.04f;
            int a = 2000000;
            int b = 2500000;
            int c = 1500000;
            Console.WriteLine("Muc luong nam toi cua Nv1 la " + (a + (a * h)).ToString("0.00"));
            Console.WriteLine("Muc luong nam toi cua Nv2 la " + (b + (b * h)).ToString("0.00"));
            Console.WriteLine("Muc luong nam toi cua Nv3 la " + (c + (c * h)).ToString("0.00"));
            Console.ReadKey();

        }
    }
}
