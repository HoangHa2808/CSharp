using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap9
{
    class MoveEstimator
    {
        static void Main(string[] args)
        {
            const double PhiCoBan = 200;
            const double Gio = 150;
            const double Dam = 2;

            Console.Write("Nhap so gio : ");
            double gio = double.Parse(Console.ReadLine());
            Console.Write("Nhap so dam : ");
            double dam = double.Parse(Console.ReadLine());
            double TongPhi = (Gio * gio) + (Dam * dam) + PhiCoBan;
            Console.WriteLine("({0} gio * ${1}) + ({2} dam * ${3}) + ${4} phi co ban\n", gio, Gio, dam, Dam, PhiCoBan);
            Console.WriteLine(" => Phi uoc tinh la : ${0}", TongPhi);

            Console.ReadKey();
        }
    }
}
