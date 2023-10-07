using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    /*
     * Tính đa hình
     * Tính đa hình trong OOP được hiểu là sự thể hiện khác nhau của 
     * cùng 1 hành động trên các đối tượng khác nhau hoặc cùng 1 đối
     * tượng nhưng ở trong các trường hợp khác nhau.
     * VD: Cùng là hoạt động chạy của đối tượng A nhưng khi A chạy 
     * tập thể dục khác với khi A chạy đi WC.
     * Cùng là hoạt động chạy tập thể dục nhưng đối với A chạy sẽ khác
     * với B chạy. 2 Hoạt động trên đều thể hiện tính đa hình.
     * Trong OOP, Các hành động của đối tượng đều thể hiện thông qua
     * các phương thức do đó tính đa hình cũng được thể hiện thông qua
     * các phương thức. Cụ thể chúng ta có 2 cách là overload và override
     * Overload (Nạp chồng): là hành động tạo các phương thức có cùng tên, 
     * cùng class, khác tham số truyền vào. => Cùng đối tượng, khác trường hợp
     * Override (Ghi đè): là hành động định nghĩa lại phương thức trên các 
     * đối tượng khác nhau, các phương thức đó chỉ khác nhau ở phần thân,
     * yêu cầu là phải kế thừa trước.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Concho cc = new Concho();
            //cc.Chay();
            //cc.Chay(2);
            //Chota ct = new Chota();
            //Chotay ct2 = new Chotay();
            //ct.Chay(2);
            //ct2.Chay(2);
            Ca ca = new Camap();
            ca.An();
            // Không thể tạo được một đối tượng thuộc
            // lớp ảo bằng constructor của chính nó
            // Đối tượng của lớp trừu tượng có thể triển 
            // khai được phương thức của lớp dẫn xuất
            Console.ReadKey();
        }
    }
}
