using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ChungCu : KhuDat
    {
        private int Tang;

        public ChungCu()
        {
        }

        public ChungCu(string diaDiem, long giaBan, int dienTich, int tang) : base(diaDiem,giaBan,dienTich) 
        {
            this.Tang1 = tang;
        }

        public int Tang1 { get => Tang; set => Tang = value; }

        public override void input()
        {
            base.input();
            Console.WriteLine("Tang");
            Tang = int.Parse(Console.ReadLine());

        }
        public override void show()
        {
            base .show();
            Console.Write($", {this.Tang}");
        }
    }
}
