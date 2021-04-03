using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap14
{
    class TestsInteractive
    {
        static void Main(string[] args)
        {
            double Toan = 8.8,
                Van = 7.6,
                Anh = 6.8,
                Ly = 8.1,
                Hoa = 7.9,
                Sinh = 7.6,
                Dia = 8.6,
                Su = 8.7;
            
            double diem;
            double tongDiemTB = (Toan + Van + Anh + Ly + Hoa + Sinh + Dia + Su)/ 8;
            diem = Math.Round(tongDiemTB, 2);
            
            Console.Write("Tong diem Tb bang : {0}", diem);
            Console.ReadKey();
        }
    }
}
