using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_Function
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
        //1. Hàm không trả về, không truyền vào - hàm void và không có tham số
        // Viết 1 hàm không trả về, không truyền vào để thực hiện in ra một
        // số được tạo ngẫu nhiên
        static void TaoSoNgauNhien()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                // Khởi tạo một đối tượng random 
                int x = r.Next(1, 1000);
                // Phương thức này tạo ra một giá trị ngẫu nhiên từ 1 đến 1000
                Console.WriteLine("Bạn vừa tạo một giá trị random là " + x);
            }
        }
        // Hàm không trả về, có truyền vào
        static void TinhBMI(double cao, double nang)// Đơn vị: m
        {
            double bmi = nang / (cao * cao);
            Console.WriteLine($"Người cao: {cao} và nặng: {nang} có chỉ số " +
                $"BMI là: {bmi}");
        }
        // Lưu ý double cao, double nang gọi là parameters: Tham số
        // các giá trị 1.8 và 80 gọi là argument: Đối số
        // 3. Hàm trả về, không truyền vào 
        static int TinhTuoi() // Bắt buộc phải return
        {
            Console.WriteLine("Nhập năm sinh của bạn: ");
            int namsinh = Convert.ToInt32(Console.ReadLine());
            int namhientai = DateTime.Now.Year; // DateTime.Now = thời điểm hiện tại
            return namhientai - namsinh;
        }
        // 4 Hàm trả về có truyền vào tham số
        // Viết hàm truyền vào 2 đáy và chiều cao của hình thang, tính và trả về diện
        // tích hình thang đó (đáy 1: a, đáy 2: b, cao h thì S = (a+b)*h/2
        static double TinhSHinhThang(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
        // Những hàm như vậy thường được sử dụng trong tính toán mà không cần in ra
        // giá trị cụ thể
        // -- Viết hàm truyền vào x và y, trả về nhưng phải in ra căn bậc x của y
        // Gợi ý: Dùng hàm Math.Pow và trả về 1 string chứa kết quả và in ra string đó
        static string TinhCanBac(double x, double y)
        {
            string ketqua = $"Kết quả của phép tính căn bậc {x} của {y} là: ";
            double canbac = Math.Pow(y, 1.0 / x);
            return ketqua + canbac;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TaoSoNgauNhien();
            //TinhBMI(1.80, 80);
            //int tuoi = TinhTuoi(); // Khi được gọi lại thì hàm trả về có vai trò như giá trị
            // cụ thể, trong trường hợp trên TinhTuoi() được sử dụng như 1 số int 
            //Console.WriteLine("Tuổi của bạn là " + tuoi);
            //Console.WriteLine("Tuổi của bạn là " + TinhTuoi());
            //Console.WriteLine(TinhSHinhThang(5.5, 8.5, 6));
            Console.WriteLine(TinhCanBac(3, 28));
            Console.ReadKey();
        }
    }
}
