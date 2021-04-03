using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap12
{
    class EggsInteractive
    {
        static void Main(string[] args)
        {
            int Ta = 12;
            int SoTrung;
            Console.Write("Nhap so trung can doi : ");
            SoTrung = int.Parse(Console.ReadLine()); 
            int Qua = SoTrung % Ta;
            int Chuc = SoTrung / Ta;
            Console.WriteLine("=> {0} trung gom {1} ta va {2} qua", SoTrung, Chuc, Qua);
            Console.ReadKey();
        }
    }
}
