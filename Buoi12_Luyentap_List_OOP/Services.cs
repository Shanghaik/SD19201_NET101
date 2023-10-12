using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi12_Luyentap_List_OOP
{
    internal class Services
    {
        List<Giaovien> giaoviens = new List<Giaovien>(); // để nhập xuất
        public Services()   {   }
        public Services(List<Giaovien> giaoviens)
        {
            this.giaoviens = giaoviens;
        }
        public void NhapDanhSach()
        {
            Console.WriteLine("Nhập số lượng");
            int count = Convert.ToInt32(Console.ReadLine());
            // Nhập các Giáo viên và thêm vào trong List
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Nhập id của GV:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tên của GV:");
                string ten = Console.ReadLine();
                Console.WriteLine("Nhập số giờ dạy của GV:");
                double gioday = Convert.ToDouble(Console.ReadLine());
                // Tạo đối tượng GV từ dữ liệu vừa nhập
                Giaovien gv = new Giaovien(id, ten, gioday);
                // Thêm đối tượng vừa tạo vào List
                giaoviens.Add(gv);
            }
            // Tạo 1 biến để hỏi xem người dùng có muốn nhập tiếp hay ko?
            Console.WriteLine("Bạn có muốn nhập tiếp không? Y: Có/ Còn lại: Không");
            string again = Console.ReadLine();
            if (again == "Y") NhapDanhSach(); // Gọi lại chính hàm này để nhập tiếp
            else Console.WriteLine("Nhập xong");
        }
        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sách Giảng viên là: ");
            foreach (var item in giaoviens)
            {
                item.InThongTin();
            }
        }
    }
}
