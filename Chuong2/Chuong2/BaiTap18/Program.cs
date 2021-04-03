using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap18
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string a, b, c;
            Console.Write("Nhap ten : ");
            a = Console.ReadLine();
            Console.WriteLine("Ten cua ban la : {0}", a);
            
            b = a.Substring(0,1);
            a = a.Substring(1);
            c = a + b + "ay";
            Console.WriteLine("Ten thay doi la : {0}", c);
            Console.ReadKey();

        }
    }
}
