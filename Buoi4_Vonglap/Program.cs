using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_Vonglap
{
    /*
     * Vòng lặp là gì? Là tập hợp các câu lệnh được viết theo
     * một cấu trúc nào đó cho phép thực thi lặp đi lặp lại
     * một chức năng nào đó cho đến khi dừng theo một điều
     * kiện cụ thể nào đó. Trong C# ta có có các loại vòng lặp
     * for, while, dowhile và foreach
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            // VD1: Viết vòng lặp in ra danh sách các số nguyên từ 
            // 1 đến 10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + ", ");
            //}
            // cặp dấu {} được hiểu là đánh dấu cho 1 khối lệnh (nhiều lệnh)
            // đối với vòng lặp chúng ta áp dụng trên một khối lệnh
            // khi khối lệnh chỉ gồm 1 câu lệnh duy nhất ta có thể bỏ {}
            // VD2: Viết vòng lặp để in ra danh sách các số lẻ chia hết cho
            // 3 trong khoảng từ -100 đến 100 (kết hợp với câu lệnh điều kiện)
            int i = -102;
            for (; i < 101;)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }
                i++;
            }
            // Lưu ý, với vòng lặp for, ta có thể khởi tạo biến chạy trước
            // khi có vòng lặp, thành phần update biến (bước nhảy) cũng có
            // thể bỏ qua nếu ta update ngay trong khối lệnh của for
            // Khi đó vòng lặp for có cấu trúc không khác gì vòng lặp while
            // Thành phần điều kiện là thành phần duy nhất phải có
            Console.WriteLine("\nI sau vòng lặp có giá trị là: " + i);
            while (i < 101)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }
                i--;
            }
            // Vòng lặp while hoặc for có thể không chạy lần nào nếu điều kiện
            // ngay từ đầu đã không thỏa mãn. Tuy nhiên với vòng lặp do-while
            // thì code vẫn chạy ít nhất 1 lần ngay cả khi điều kiện sai
            int dem = 0;
            //do
            //{
            //    Console.Write(i + ", ");
            //    i -= 1000000; dem++;
            //} while (i != 0 && dem < 100000);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int k = int.MaxValue;
            Console.WriteLine(k + 1);
            Console.WriteLine(k + 2);
            // ++ --
            int z = 9;
            // Console.WriteLine($"{z++} {++z} {--z} {z--} {z}");
            // Sử dụng vòng lặp để Nhập thông tin của những người yêu cũ
            // bao gồm: chiều cao, cân nặng, sở thích, tuổi
            Console.ReadKey();
        }
    }
}
