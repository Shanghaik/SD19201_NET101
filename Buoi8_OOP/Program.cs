using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8_OOP
{
    /*
     * OOP - Object Oriented Programing - Lập trình hướng đối tượng
     * Là một phương pháp lập trình cho phép chúng ta sử dụng các đối
     * tượng để mô hình hóa các sự kiện, hành động,...Mọi thứ đều có
     * thể dử dụng các đối tượng để mô tả => Lập trình dễ hình dung hơn
     * phù hợp với thực tế cuộc sống.
     * Khi lập trình OOP, chúng ta sử dụng các Class - lớp để thực hiện
     * làm khuôn mẫu cho một hay nhiều đối tượng.
     * Trong OOP chúng ta luôn luôn có 4 tính chất:
     * - Tính bao đóng (đóng gói): Là chính chất để cho phép truy cập
     * đến các thành phần của đối tượng
     * - Tính kế thừa: Cho phép các Class kế thừa lần nhau hoặc kế thừa
     * từ các interface khi chúng có những đặc điểm chung có thể kế thừa lại
     * - Tính đa hình: Thể hiện sự khác nhau trong việc thực thi các hành
     * động của đối tượng (thông qua các phương thức) trong các điề kiện
     * khác nhau
     * - Tính trừu tượng: Cho phép chúng ta xây dựng các mô hình theo hướng
     * trừu tượng hóa và được thể hiện lại ở các lớp dẫn xuất
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo đối tượng bằng constructor
            Connguoi nguoi1 = new Connguoi(); // Không tham số
            // Gọi phương thức của đối tượng
            nguoi1.InThongTin();
            Connguoi nguoi2 = new Connguoi("Lê Văn Luyện", DateTime.Now, true, "Bắc Giang", "Học sinh");
            nguoi2.InThongTin();
            Connguoi nguoi3 = new Connguoi("Năm Cam", DateTime.Now, "Sài Gòn");
            nguoi3.Gioitinh = true; // Sử dụng Property để gán giá trị
            nguoi3.InThongTin();
            Console.WriteLine("Tên người số 3 là: "+ nguoi3.Ten); // Sử dụng Property để lấy giá trị
            Console.ReadKey();
        }
    }
}
