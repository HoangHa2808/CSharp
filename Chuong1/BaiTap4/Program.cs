using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BaiTap4
{
    class PersonalInfo
    {
        static void Main(string[] args)
        {
            Console.Write("\tHay nhap ten cua ban : ");
            Console.WriteLine("Ten cua ban la : " + Console.ReadLine());
            Console.Write("\tHay nhap ngay sinh cua ban : ");
            Console.WriteLine("Ngay sinh cua ban la : " + Console.ReadLine());
            Console.Write("\tHay nhap SDT co quan : ");
            Console.WriteLine("SDT co quan la : " + Console.ReadLine());
            Console.Write("\tHay nhap SDT ca nhan : ");
            Console.WriteLine("SDT ca nhan la : " + Console.ReadLine());
            Console.ReadKey();
        }
    }
}
