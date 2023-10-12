using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi12_Luyentap_List_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Giaovien> gvs = new List<Giaovien>();
            Services services = new Services(gvs);
            while (true)
            {
                Console.WriteLine("Mời bạn chọn chức năng: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        services.NhapDanhSach();
                        break;
                    case "2":
                        services.XuatDanhSach();
                        break;
                    case "3":
                        services.XuatDanhSachTheoKhoang();
                        break;
                    case "4":
                        services.XoaIDChanC2();
                        break;
                    case "0":
                        Environment.Exit(0);    
                        break;
                }
            }
        }
    }
}
