using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    class InchesToCentimeterslnteractive
    {
        static void Main(string[] args)
        {
            float a = 2.54f;
            int b;
            Console.Write(" Nhap gia tri can tinh = ");
            b = int.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine(" = > {0} inch = {1} cm ", b, c);
            Console.ReadKey();
        }
    }
}
