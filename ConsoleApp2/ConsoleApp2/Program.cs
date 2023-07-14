    using System.Text;
using System;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập số lượng mảnh đất: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<KhuDat> khulist = new List<KhuDat>(N);
            KhuDat khu = new KhuDat();
            long tong = 0;
            do
            {

                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("|\t0. Thoát chương trình                                          |");
                Console.WriteLine("|\t                 ---MENU---                                    |");
                Console.WriteLine("|\t1------Thêm 1 Khu Đất------------------------------------------|");
                Console.WriteLine("|\t2------Thêm 1 Nhà Phố------------------------------------------|");
                Console.WriteLine("|\t3------Thêm 1 chung cư-----------------------------------------|");
                Console.WriteLine("|\t4------Xuất hết danh sách--------------------------------------|");
                Console.WriteLine("|\t5--tính tổng tiền của cả danh sách-----------------------------|");
                Console.WriteLine("|\t6--Khu đất >100m2 hoặc nha phố >60m2 và năm xây dựng>= 2020----|");
                Console.WriteLine("|\t7--Tìm kiếm đất trùng địa điểm, gần giá tiền và diện tích----  |");
                Console.WriteLine("|____________________________________________________________________|");
                Console.WriteLine("Mời Nhập chức năng:");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        khu = new KhuDat();
                        khu.input();
                        khulist.Add(khu);
                        break;
                    case 2:
                        khu = new NhaPho();
                        khu.input();
                        khulist.Add(khu);
                        break;
                    case 3:
                        khu = new ChungCu();
                        khu.input();
                        khulist.Add(khu);
                        break;



                    case 4:
                        Console.WriteLine("Xuất danh sách quản lý: ");
                        foreach (var item in khulist)
                        {
                            item.show();
                            Console.Write("\n");
                        }
                        Console.ReadKey();

                        break;
                    case 5:
                        long a = Tonggiaban(khulist);
                        Console.WriteLine($"{a}");

                        break;
                    case 6:
                        List<KhuDat> list = khulist.Where(p => p.DienTich1 > 100 || p.DienTich2>60 && p.NamXayDung).ToList();
                        if (list.Count() != 0)
                            XuatDS(list);
                        else
                        {
                            Console.WriteLine("Không tìm thấy");
                        }
                        break;
                    case 7:
                        KhuDat khu1 = new KhuDat();
                        khu1 = new KhuDat();
                        khu1.input();
                        List<KhuDat> list1 = khulist.Where(p => p.DiaDiem1 == khu1.DiaDiem1 && p.GiaBan1 <= khu1.GiaBan1 && p.DienTich1 <= khu1.DienTich1).ToList();
                        if (list1.Count() != 0)
                        {
                            XuatDS(list1);
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy");
                        }
                        break;

                }
                if (khulist.Count() == N)
                {
                    Console.WriteLine("Bộ nhớ đã đầy vui lòng chỉ sử dụng chức năng đừng nhập thêm");
                }
            } while (N != 0);
            Console.ReadKey();



            long Tonggiaban(List<KhuDat> khulist)
            {
                long sum = khulist.Sum(x => Convert.ToInt32(x.GiaBan1));
                return sum;
            }
            void XuatDS(List<KhuDat> khulist)
            {
                foreach (var item in khulist)
                {
                    item.show();
                    Console.Write("\n");
                }
                Console.ReadKey();
            }
           
    
        }
    }
}