using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyChuoi
{
    internal class Program
    {
        // Chuỗi - string trong C# là một kiểu dữ liệu cho phép người dùng lưu trữ dữ liệu
        // dưới dạng text. Chuỗi là kiểu dữ liệu chỉ đọc - chúng ta chỉ có thể lấy dữ liệu
        // từ chuỗi mà không thể chỉnh sửa chuỗi một cách trực tiếp thông qua việc 
        // truy xuất tới các kí tự. Các kí tự trong chuỗi có thể được trỏ tới như một phần
        // tử trong mảng thông qua vị trí.
        // Có thể tác động được lên chuỗi thông qua việc sử dụng các phương thức từ các thư
        // viện đã được dựng sẵn
        // 1. Viết hàm truyền vào một chuỗi s, sau đó kiểm tra xem s có chứa kí tự A hay không?
        // 2. Viết hàm cho phép nhập 1 chuỗi s, sau đó đếm số kí tự a ở trong chuỗi
        // 3. Viết hàm truyền vào 1 chuỗi s, sao đó thay thế tất cả các kí tự z trong s thành w
        // và w trong s thành z ví dụ AzxwzAw => AwxzwAz
        // 4. Viết tắt tên của người theo quy tắc Tên viết tắt = Tên + kí tự đầu của các thành phần
        // còn lại bắt đầu từ họ, ví dụ Pham Gia Khanh => KhanhPG, Le Van Luyen => LuyenLV
        static void Cau1(string s)
        {
            Console.WriteLine($"Chuỗi {s} {(s.Contains("A") ? "Có" : "Không")} chứa kí tự A");
        }
        static void Cau2()
        {
            Console.WriteLine("Nhập chuỗi s");
            string s = Console.ReadLine();
            // Cách 1: duyệt qua chuỗi
            int dem = 0;
            foreach (char kitu in s)
            {
                if (kitu == 'a') dem++;
            }
            Console.WriteLine($"Số kí tự a trong chuỗi {s} là {dem}");
            // Cách 2: 
            int dem2 = s.Length - s.Replace("a", "").Length;
            // Lấy độ dài ban đầu trừ đi độ dài khi thay thế các kí tự a bằng kí tự rỗng (xóa hết a đi)
            Console.WriteLine($"Số kí tự a trong chuỗi {s} là {dem2}");
        }
        // Câu 3
        static void Cau3(string s) // Cách không triệt để
        {
            // Thực hiện đổi tất cả w thành | 
            s = s.Replace("w", "|");
            // Thực hiện đổi tất cả z thành w 
            s = s.Replace("z", "w");
            // // Thực hiện đổi tất cả | thành z
            s = s.Replace("|", "z");
            Console.WriteLine($"Sau khi thay đổi thì kết quả là {s}");
        }
        // Cách triệt để của câu 3
        // Lưu tất cả vị trí strong s là w và z sau đó thay đổi theo các vị trí đó
        static void Cau3_2(string s)
        {
            List<int> zIndex = new List<int>();
            List<int> wIndex = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'w') wIndex.Add(i);
                if (s[i] == 'z') zIndex.Add(i);
            }
            char[] schars = s.ToCharArray();
            foreach (int index in zIndex)
            {
                schars[index] = 'w';
            }
            foreach (int index in wIndex)
            {
                schars[index] = 'z';
            }
            s = string.Join("", schars);
            Console.WriteLine($"Sau khi thay đổi thì kết quả là {s}");
        }
        // Câu 4
        static void Cau4(string ten)
        {
            string[] mangten = ten.Split(' '); // Cắt từng âm tiết trong tên ra
            string ketqua = mangten[mangten.Length - 1]; // Gán tên vào đầu kết quả
            // Ví dụ Pham Gia Khanh cắt ra thành {Pham, Gia, Khanh} thì length = 3
            // mangten[mangten.Length - 1] = mangten[3-1] = mangten[2] là Khanh và là đầu của kết quả
            for (int i = 0; i < mangten.Length - 1; i++)
            {
                ketqua += mangten[i][0]; // Gán kí tự đầu của mỗi âm tiết vừa bị cắt ra ngoại trừ tên
            }
            Console.WriteLine(ketqua);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Cau1("abcdAxxx");
            //Cau2();
            Cau3("zw|wz--Az");
            Cau3_2("zw|wz--Az");
            Cau4("Pham Gia Khanh Dep Trai");
            string s = "ABCDAEF";
            Console.WriteLine(s[1]);
            // IndexOf/LastIndexOf trả về vị trí của một chuỗi trong chuỗi gốc
            // Vị trí này được tính là vị trí đầu tiên của chuỗi con trong chuỗi gốc, -1 nếu ko có
            Console.WriteLine(s.IndexOf("ABC"));
            // Contains để kiểm tra sự tồn tại của chuỗi con trong chuỗi gốc, trả về bool
            Console.WriteLine(s.Contains("ABC"));
            // Concat dùng để nối chuỗi nhưng trả về 1 list kí tự 
            var v = s.Concat("XXXX");
            Console.WriteLine(string.Join("-", v));
            // ToCharArray, sẽ trả về 1 mảng kí tự từ 1 chuỗi (sẽ có thể sử được các phần tử)
            // Replace trả về 1 chuỗi mà các thành phần con đã được thay thế bằng thành phần khác
            Console.WriteLine(s.Replace("A", "a"));
            // Remove(a, b) cho phép xóa các kí tự từ vị trí a đến vị trí b trong chuỗi
            Console.WriteLine(s.Remove(1, 3));
            // Remove(a) xóa từ a đến hết
            Console.WriteLine(s.Remove(4));
            // string.Join cho phép kết hợp tất cả các phần tử của 1 tập hợp tạo thành 1 chuỗi
            // thông qua 1 seperator (kí tự/chuỗi nối)
            Console.WriteLine(string.Join("@", s.ToCharArray()));
            // Trim() để xóa đi các kí tự khoảng trắng ở đầu và cuối của chuỗi
            // StartWith/EndWith để kiểm tra xem chuỗi có bắt đầu/kết thúc bởi 1 chuỗi nào đó hay ko?
            Console.WriteLine(s.StartsWith("ABC") + " " + s.EndsWith("ABC"));
            // Split cho phép cắt 1 chuỗi ra thành một mảng thông qua kí tự nhận diện 
            string z = "ABC-1234-555-ajsd";
            string[] cutZ = z.Split('-');
            Console.WriteLine(string.Join("|", cutZ));
            Console.ReadKey();
        }
    }
}
