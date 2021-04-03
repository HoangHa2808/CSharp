using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaiTap11
{
    class Eggs
    {
        static void Main(string[] args)
        {
            int SoTrung = 153;
            int qua = 12;
            int ta = 0;
            ta = SoTrung / qua;
            qua = SoTrung % qua;
            Console.WriteLine(" {0} qua gom {1} ta va {2} qua", SoTrung, ta, qua);
            Console.ReadKey();
        }
    }
}
