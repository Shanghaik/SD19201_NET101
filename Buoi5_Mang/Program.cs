using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5_Mang
{
    /*
     * Mảng (array) là một tập hợp các phần tử có cùng kiểu dữ liệu
     * cú pháp khai báo: kiểu_dữ_liệu[] tên_mảng;
     * Mảng khi đã được khai báo sẽ có số phần tử cố định và mỗi phần tử
     * sẽ có thể mang giá trị mặc định cho kiểu dữ liệu của mảng
     * Mảng được dùng để chứa dữ liệu, thuận tiện cho truy vấn thông qua
     * index-chỉ mục-vị trí của phần tử trong mảng. Mảng bắt đầu từ 0
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] crr; // Khai báo mảng đơn thuần - không thể sử dụng nếu không được gán gía trị
            //int[] brr = new int[10]; // Khai báo mảng có 10 phần tử
            //int[] arr = {1,2,3,4,5,6,7}; // khởi tạo 1 mảng = dữ liệu có sẵn
            //// arr = brr; // gán arr = brr 
            //// In các phần tử trong mảng
            //// 1. Dùng vòng lặp for/while
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] +" ");
            //}
            //Console.WriteLine();
            //foreach (int item in brr)
            //{
            //    Console.Write(item +" ");
            //}
            // foreach là 1 dạng vòng lặp sẽ duyệt qua tất cả các phần tử của một
            // tập hợp dữ liệu nào đó trong đó. var item là một đại diện cho từng phần
            // tử trong tập hợp, in thể hiện nằm trong và collection là tập hợp mình
            // muốn duyệt qua
            //int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //brr = temp;
            //for (int i = 0; i < brr.Length; i++)
            //{
            //    Console.Write(brr[i] + " ");
            //}
            // break và continue
            // break cho phép chúng ta ngay lập tức dừng hoạt động của 1 cấu trúc lệnh
            // continue khi sử dụng với vòng lặp cho phép ta bỏ qua lần lặp đó
            // in ra danh sách tất cả các số không chia hết cho 3 trong khoảng 1-100
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0) continue;// break; // Khi gặp số %3 thì bỏ qua vòng lặp
            //    Console.Write(i + " ");
            //}
            
            // In 1 mảng trên 1 dòng mà không cần vòng lặp
            int[] arr = { 1, 22, 3, 324, 67, 13, 345 };
            Console.WriteLine(string.Join("---", arr));
            // Phương thức string.Join cho phép chúng ta kết hợp tất cả phần tử của
            // một tập hợp nào đó thành 1 chuỗi thông qua 1 chuỗi kí tự nối
            Console.ReadKey(); // Dừng màn hình để đọc 1 key - phím
        }
    }
}
