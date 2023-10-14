using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTongHop
{
    internal class Services
    {
        List<Bike> bikes = new List<Bike>();
        public Services()
        {
        }
        public Services(List<Bike> bikes)
        {
            this.bikes = bikes;
        }

        public void NhapDanhSach()
        {
            Console.WriteLine("Nhập số lượng");
            int count = Convert.ToInt32(Console.ReadLine());
            // Nhập các Giáo viên và thêm vào trong List
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Nhập id của Xe:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tên của Xe:");
                string ten = Console.ReadLine();
                Console.WriteLine("Nhập Hãng sản xuất:");
                string hang = Console.ReadLine();
                // Tạo đối tượng GV từ dữ liệu vừa nhập
                Bike bike = new Bike(id, ten, hang);
                // Thêm đối tượng vừa tạo vào List
                bikes.Add(bike);
            }
            // Tạo 1 biến để hỏi xem người dùng có muốn nhập tiếp hay ko?
            Console.WriteLine("Bạn có muốn nhập tiếp không? Y: Có/ Còn lại: Không");
            string again = Console.ReadLine();
            if (again == "Y") NhapDanhSach(); // Gọi lại chính hàm này để nhập tiếp
            else Console.WriteLine("Nhập xong");
        }
        public void XuatDanhSach()
        {
            if (bikes.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng mới bạn nhập đã");
                NhapDanhSach();
            }
            foreach (var item in bikes)
            {
                item.InThongTin();
            }
        }
        public void SuaDanhSach()
        {
            int count = 0;
            foreach (var item in bikes)
            {
                if (item.HangSx == "Yamaha")
                {
                    item.HangSx = "Honda"; count++;
                }
            }
            Console.WriteLine($"Bạn đã sửa {count} xe");
        }
        // Cách 1: Có thể dử dụng IComparable và IComparer để sắp xếp
        // Cách 2: Sắp xếp nổi bọt trên List
        // Cách 3: Sử dụng Phương thức OrderBy
        public void SapXepIDDesc()
        {
            bikes = bikes.OrderByDescending(p => p.Id).ToList(); // Giảm dần
            // bikes = bikes.OrderBy(p=>p.Id); Tăng dần
            // p=>p.ID là xác định thuộc tính nào sẽ được sắp xếp, trong trường hợp trên là ID
            XuatDanhSach();
        }
    }
}
