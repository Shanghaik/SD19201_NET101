using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_Ham_Function
{
    /*
     * Hàm (function) trong lập trình được hiểu là một tập hợp các câu lệnh được
     * viết gói gọn và đặt tên để có thể được gọi lại và sử dụng nhiều lần khi 
     * cần thiết. Lợi ích khi sử dụng hàm là code có thể tái sử dụng, dễ bảo trì
     * khiến cho code được rõ ràng hơn,...
     * Hàm được phân biệt và đánh giá theo nhiều khía cạnh khác nhau tuy nhiên
     * ta thường phân loại hàm thông qua kiểu trả về và tham số truyền vào
     * hàm được đánh dấu là void là hàm không trả về mà chỉ thực hiện các chức
     * năng cụa thể nào đó. Số lượng tham số của hàm cũng không giới hạn
     * Phần code của hàm luôn luôn nằm trong {}
     * Tên hàm đặt theo nguyên tắc UpperCase- viết hoa chữ cái đầu tiên từng tiếng
     */
    internal class Program
    {
        static void NhapXuatDuLieu()// Không truyền vào/không trả về
        {
            Console.WriteLine("Nhập một số nguyên: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bạn vừa nhập số nguyên: " + x);
        }
        // 1.Viết hàm nhập dữ liệu cho một mảng số nguyên có kích thước n
        // 2. n do người dùng nhập vào (Gán arr[i] = nhập)
        // 3. in ra mảng đó
        static void NhapXuatMang()
        {
            Console.WriteLine("Nhập số phần tử của mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Mời nhập các phần tử của mảng");
            for (int i = 0; i < n; i++) // n hoặc arr.Length đều được
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Danh sách mảng vừa nhập là: ");
            Console.WriteLine(string.Join(", ", arr));
        }
        // 1.Viết hàm nhập dữ liệu cho một mảng số nguyên có kích thước n
        // 2. n do được truyền vào là 1 tham số kiểu int
        // 3. in ra mảng đó
        static void NhapXuatMang2(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Mời nhập các phần tử của mảng");
            for (int i = 0; i < n; i++) // n hoặc arr.Length đều được
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Danh sách mảng vừa nhập là: ");
            Console.WriteLine(string.Join(", ", arr));
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //NhapXuatDuLieu();// Gọi hàm - Khi gọi hàm void chỉ cần gọi tên
            NhapXuatMang();
            NhapXuatMang2(6);
            Console.ReadKey();
        }
    }
}
