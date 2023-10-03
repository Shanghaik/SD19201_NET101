using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8_OOP
{
    // Class được tạo ra để làm khuôn mẫu cho các đối tượng
    // Trong class có các thành phần sau:
    // Thuộc tính - các thông tin của đối tượng
    // Constructor (hàm tạo) - được dùng để tạo thuộc tính cho đối tượng
    // Properties - Được dùng để truy suất tới các thuộc tính
    // Method - Phương thức để thể hiện các hành động đăc chưng của đối tượng
    internal class Connguoi
    {
        // Các thuộc tính
        string ten;
        DateTime ngaysinh = DateTime.Now; // Đây cũng là giá trị mặc định
        bool gioitinh;
        string diachi;
        string nghenghiep = "Giáo viên";

        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        // Để tạo property 
        // Bước 1: bôi đen các thuộc tính mà mình cần tạo
        // Bước 2: chuột phải chọn Quick Action hoặc Ctrl + '.'
        // Bước 3: Chọn Encapsulate Field ... and use Property
        // get: Lấy ra dữ liệu, set: Gán dữ liệu cho thuộc tính
        // constructor - có 2 loại
        // constructor không tham số được sử để tạo ra các đối tượng với thuộc tính
        // mang các giá trị mặc định (có thể tự tạo ra nếu lập trình viên định nghĩa)
        public Connguoi() // gõ ctor + 2 lần tab
        {
            Ten = "KhanhPG"; // Giá trị mặc định (Giá trị này sẽ được ưu tiên hơn)
            Nghenghiep = "Công an";
        }
        // Constructor có tham số (Ctrl + '.' => Generate Contructor => Chọn thuộc tính mình muốn
        // => chọn OK và kiểm tra lại kết quả
        public Connguoi(string ten, DateTime ngaysinh, bool gioitinh, string diachi, string nghenghiep)
        {
            this.Ten = ten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Nghenghiep = nghenghiep;
        }
        // Cũng là có tham số nhưng chỉ có 3 tham số
        public Connguoi(string ten, DateTime ngaysinh, string diachi)
        {
            this.Ten = ten;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
        }
        // constructor có tham số được sử dụng để tạo đối tượng với các thuộc tính có giá trị
        // bằng với các giá trị được truyền vào
        // 4: Các phương thức
        public void InThongTin()
        {
            Console.WriteLine("Thông tin cá nhân của đối tượng bị truy nã: ");
            Console.WriteLine($"Tên: {ten}, Tuổi: {DateTime.Now.Year - ngaysinh.Year}");
            string gt = gioitinh ? "Nam" : "Nữ"; // Nếu gioitinh true thì là Nam, false là Nữ
            Console.WriteLine($"Giới tính {gt}, Nghề nghiệp: {nghenghiep}");
        }
    }
}
