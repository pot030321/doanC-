using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class KhuDat
    {
        private String DiaDiem;
        private long GiaBan;
        private int DienTich;
        public KhuDat()
        {

        }

        public KhuDat(string diaDiem, long giaBan, int dienTich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
        }

        public int DienTich1 { 
            set { DienTich = value; } 
            get { return DienTich; }
        }

        public string DiaDiem1 { get => DiaDiem; set => DiaDiem = value; }
        public long GiaBan1 { get => GiaBan; set => GiaBan = value; }
        public int DienTich2 { get => DienTich; set => DienTich = value; }
        public bool NamXayDung { get; internal set; }

        public virtual void input()
        {
            Console.WriteLine("Dia diem");
            DiaDiem = Console.ReadLine();
            Console.WriteLine("Gia Bán");
            GiaBan = long.Parse(Console.ReadLine());
            Console.WriteLine("Dien Tich");
            DienTich = int.Parse(Console.ReadLine());

        }
    
        public virtual void show()
        {
            Console.Write($"{this.DiaDiem}, {this.GiaBan}, {this.DienTich}");
        }
    }
}
