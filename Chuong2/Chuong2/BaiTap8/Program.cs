using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTap8
{
    class ProjectedRaisesInteractive
    {
        static void Main(string[] args)
        {
            const float SoPhanTramTangTrongNamToi = 0.04f;
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("\tMuc luong cua nhan vien ");
            Console.Write("Nhap luong cua Nv1 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong cua Nv2 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong cua Nv3 : ");
            c = int.Parse(Console.ReadLine());
           
            Console.WriteLine(" Luong nam toi cua Nv1 la : " + (a + (a * SoPhanTramTangTrongNamToi)).ToString("0.00"));
            Console.WriteLine(" Luong nam toi cua Nv2 la : " + (b + (b * SoPhanTramTangTrongNamToi)).ToString("0.00"));
            Console.WriteLine(" Luong nam toi cua Nv3 la : " + (c + (c * SoPhanTramTangTrongNamToi)).ToString("0.00"));
            Console.ReadKey();
        }
    }
}
