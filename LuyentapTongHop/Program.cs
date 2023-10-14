using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTongHop
{
    internal class Program
    {
        // Menu trả về 
        public static string Menu() // Hàm trả về
        {
            Console.WriteLine("1: Nhập danh sách");
            Console.WriteLine("2: Xuất danh sách");
            Console.WriteLine("3: Sửa Yamaha thành Honda");
            Console.WriteLine("4: Sắp sếp giảm dần theo ID");
            Console.WriteLine("0: Thoát");
            Console.WriteLine("5: Kế thừa");
            Console.WriteLine("Mời bạn chọn chức năng: ");
            string choose = Console.ReadLine();
            return choose; // trả về lựa chọn của mình
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Bike> bikes = new List<Bike>();
            Services services = new Services(bikes);
            while (true)
            { 
                switch (Menu()) // Gọi lại luôn hàm trả về ở đây
                {
                    case "1":
                        services.NhapDanhSach();
                        break;
                    case "2":
                        services.XuatDanhSach();
                        break;
                    case "3":
                        services.SuaDanhSach();
                        break;
                    case "4":
                        services.SapXepIDDesc();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
