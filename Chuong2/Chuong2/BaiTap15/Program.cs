using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap15
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            int a = 32;
            float b = 5/9f;

            int NhietDo;
            Console.Write("Nhap nhiet do can doi : ");
            NhietDo = int.Parse(Console.ReadLine());
            float d = (NhietDo - a) * b;
            Console.WriteLine("Vay {0} se la {1} ", NhietDo, d);
            Console.ReadKey();
        }
    }
}
