using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class NhaPho: KhuDat
    {
        private int NamXayDung;
        private int SoTang;

        public NhaPho()
        {

        }
        public NhaPho(string diaDiem, long giaBan, int dienTich, int namXayDung, int soTang) : base(diaDiem,giaBan,dienTich)
        {
            NamXayDung1 = namXayDung;
            SoTang1 = soTang;
        }

        public int NamXayDung1 { get => NamXayDung; set => NamXayDung = value; }
        public int SoTang1 { get => SoTang; set => SoTang = value; }
        public override void input()
        {
            base.input();
            Console.WriteLine("Nam Xay Dung");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.WriteLine("So Tang");
            SoTang = int.Parse(Console.ReadLine());

        }
        public override void show()
        {
            base .show();
            Console.Write($", {this.NamXayDung},  {this.SoTang}");
        }
    }
}
