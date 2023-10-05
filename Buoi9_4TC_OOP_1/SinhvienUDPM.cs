using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9_4TC_OOP_1
{
    // Trong C# chúng ta có thể lập trình để class này kế thừa duy nhất 1 class khác
    // Khi kế thừa, class kế thừa (class con) sẽ chứa tất cả các thành phần của
    // class được kế thừa (class cha)
    // Cú pháp kế thừa chúng ta sử dụng dấu ':'
    internal class SinhvienUDPM : Sinhvien
    {
        string chuyennganh;
        double gpa; 
        // Điểm trung bình
        //ta khai báo thêm cho SinhvienUDPM 2 thuộc tính và nó kế thừa
        // từ Sinhvien 5 thuộc tính => sẽ có 7 thuộc tính
        public SinhvienUDPM()
        {

        }
        public SinhvienUDPM(string chuyennganh, double gpa) // Constructor riêng
        {
            this.Chuyennganh = chuyennganh;
            this.Gpa = gpa;
        }
        // constructor kế thừa từ lớp cha
        public SinhvienUDPM(string maSv, string tenSv, int khoa, DateTime dob, string nganh, string chuyennganh, double gpa)
            : base(maSv, tenSv, khoa, dob, nganh) // Từ khóa base để gọi các thành phần kế thừa
        {
            this.Chuyennganh = chuyennganh;
            this.Gpa = gpa;
        }
        // Để tạo ra constructor với tất cả các thuộc tính kể cả kế thừa ta bôi đen các thuộc tính
        // Quick Action => add Param to constructor => Chọn constructor cần thêm
        public string Chuyennganh { get => chuyennganh; set => chuyennganh = value; }
        public double Gpa { get => gpa; set => gpa = value; }
        

    }
}
