using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Kieudulieu_Nhapxuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Biến: Trong lập trình, biến được tạo ra để lưu trữ
            // dữ liệu, mỗi biến tạo ra sẽ được lưu trữ riêng
            //int a; // Khai báo
            //a = 10; // Gán giá trị
            //int b = 10; // Khởi tạo
            //Console.WriteLine(a);
            //Console.WriteLine(a = 20); // gán a = 20 trước sau đó in
            //Console.WriteLine(a);
            //int c = b;
            //b = 20;
            //Console.WriteLine(c);
            //// Để in ra toàn bộ câu lệnh a = (giá trị của a)
            //Console.WriteLine("a = " + a); // Cách 1 (Cộng chuỗi)
            //Console.WriteLine("a = {0}", a); // Cách 2: array param
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine($"a = {a}"); // Cách 3: Nhúng thẳng biến vào string
            // Ctrl + K + C để comment khối đã chọn, Ctrl K U bỏ comment
            // Ctrl K D để format code, Ctrl D để lặp code
            /*
             * Kiểu dữ liệu
             * Kiểu dữ liệu đánh dấu xem dữ liệu được nhập vào, lấy ra thuộc
             * loại dữ liệu nào, có nhiều cách để phân biệt các kiểu dữ liệu
             */
            // Kiểu nguyên thủy: int, float, double, long, short,...
            int x = 0; long y = 10; short t = 100;
            // int (Int32) có miền giá trị từ -2^31 -> 2^31-1
            // Vì thực tế các biến đều có kích thước dựa theo giá trị nhị phân
            // int có 32 bit mà 1 bit nhị phân chỉ có thể nhận 2 giá trị là 0
            // hoặc 1 nên 32 bit nhận 2^32 giá trị. Tuy nhiên số nguyên có cả
            // giá trị âm nên niền giá trị sẽ là -2^31 -> 2^31-1
            // Tìm hiểu thêm: Cách biểu diễn giá trị nhị phân
            // Kiểu dữ liệu còn lại: string, dynamic,...
            // Nhập dữ liệu 
            // Căn bản trong Csharp (Console) chúng ta sẽ nhập dữ liệu thông
            // qua kiểu string với câu lệnh Console.Realine(). Tuy nhiên có
            // Nhiều kiểu dữ liệu khác nhau nên ta phải thực hiện ép kiểu
            //string s = Console.ReadLine();
            //int r =  int.Parse(Console.ReadLine()); // Cách 1
            //int k = Convert.ToInt32(Console.ReadLine()); // Cách 2
            int m;
            //int n = int.Parse(m);
            // int z = Convert.ToInt32(m);
            // Nhập thông tin cá nhân của bạn (tên, tuổi, cân nặng)
            // sau đó in ra màn hình thông tin dạng như sau:
            /*
             * Tôi tên là x, y tuổi, nặng z kg
             */
            Console.WriteLine("Hãy nhập tên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Hãy nhập tuổi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hãy nhập cân nặng: ");
            float cannnang = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Tôi tên là {ten}, {tuoi} tuổi, nặng {cannnang} kg");


        }
    }
}
