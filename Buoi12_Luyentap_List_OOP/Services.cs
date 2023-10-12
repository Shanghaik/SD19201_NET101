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
            if(giaoviens.Count == 0)
            {
                Console.WriteLine("Danh sách trống, hãy nhập đã");
                NhapDanhSach();
            }
            Console.WriteLine("Danh sách Giảng viên là: ");
            foreach (var item in giaoviens)
            {
                item.InThongTin();
            }
        }
        public void XuatDanhSachTheoKhoang()
        {
            Console.WriteLine("Nhập số giờ dạy tối thiểu");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số giờ dạy tối đa");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danh sách Giảng viên là: ");
            foreach (var item in giaoviens)
            {
                if(item.Sogioday >= min && item.Sogioday <= max)
                {
                    item.InThongTin();
                }
            }
        }
        public void XoaIDChanC1()
        {
            int goc = giaoviens.Count;
            for (int i = 0; i < giaoviens.Count; i++)
            {
                if (giaoviens[i].Id %2 == 0)
                {
                    giaoviens.RemoveAt(i); 
                    i--; // Khi xóa xong, thì vị trí cần kiểm tra giữ nguyên
                }
            }
            Console.WriteLine($"Đã xóa {goc - giaoviens.Count} GV");
        }
        public void XoaIDChanC2()
        {
            int goc = giaoviens.Count;
            // giaovien.ToList() sẽ tạo ra 1 list mới để đối chiếu với list cũ
            foreach (var item in giaoviens.ToList())
            {
                if (item.Id % 2 == 0)
                {
                    giaoviens.Remove(item);
 
                }
            }
            Console.WriteLine($"Đã xóa {goc - giaoviens.Count} GV");
        }
        public void XoaIDChan3() // Giới thiệu, không khuyến khích
        {
            int goc = giaoviens.Count;
            giaoviens.RemoveAll(p => p.Id % 2 == 0); // LinQ với lambda expression
            Console.WriteLine($"Đã xóa {goc - giaoviens.Count} GV");
        }
    }
}
