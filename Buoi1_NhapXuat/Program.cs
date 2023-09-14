using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất các kí tự trong 1 chuỗi (string)
            string a; // Khai báo 1 biến a kiểu string
            // Khi chưa gán giá trị cho a thì giá trị của
            // a = null (không có gì cả)
            a = "ABC"; // Gán giá trị cho a
            string b = "XYZ"; // Khởi tạo biến b kiểu string
            // mang giá trị là XYZ
            // Khai báo: Chỉ cần tên biến và kiểu dữ liệu
            // Khởi tạo: Tên biến, kiểu dữ liệu và giá trị
            Console.WriteLine(a);
            // Nhập 1 chuỗi 
            string c = Console.ReadLine(); 
            Console.WriteLine(c);
        }
    }
}
