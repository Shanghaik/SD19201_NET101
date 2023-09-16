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
            Console.InputEncoding = Encoding.Unicode; 
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
            // Nhập xuất thông tin của người yêu cũ, bao gồm
            // Tên, tuổi, 3V sau đó in ra màn hình thông tin (Y hệt câu trên)
            // 3. Ép kiểu
            // Trong lập trình, không phải bao giờ dữ liệu cũng thuận tiện ngay cho
            // việc xử lý nên nhiều khi sẽ phải thực hiện việc ép kiểu để phù hợp
            // cho công việc tính toán, xử lý,...
            // Có 2 loại ép kiểu: Trực tiếp (Chủ động), Ngầm định (Bị động)
            // Ép kiểu trực tiếp là khi lập trình viên chủ động thực hiện việc ép
            // kiểu thông qua các câu lệnh còn ép kiểu ngầm định là khi chương trình
            // sẽ tự động ép kiểu để có thể thực hiện được các câu lệnh
            // a. Trực tiếp
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (int)1.5;
            double z = double.Parse("1.2345");
            // b. Ngầm định 
            float w = 1.5f + 2;
            string k = "abc" + 1; // Ép kiểu ngầm định 1 về string
            /*
             * Lưu ý: Dù là cách ép kiểu nào thì dữ liệu được được ép (convert) phải
             * thỏa mãn điều kiện đầu ra (VD: Không thể ép chuỗi abc thành int)
             * Khi ép kiểu ngầm định, thì kiểu dữ liệu đầu ra sẽ có độ bao phủ >
             * kiểu dữ liệu đầu vào
             */
            //int aa = Convert.ToInt32("abc"); // Khi chạy sẽ gây ra lỗi
            //Console.WriteLine(aa);
            //int k1 = 1932347982347834;
            string k2 = ""+ 193234798234782342423423423434.0;
            Console.WriteLine(k2);
        }
    }
}
