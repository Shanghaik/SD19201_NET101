using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9_4TC_OOP_1
{
    /*
     * 4 tính chất OOP: 
     * 1- Tính bao đóng - đóng gói
     * 2- Tính kế thừa
     * 3- Tính đa hình 
     * 4- Tính trừu tượng
     * => Tính đóng gói cho biết khả năng truy cập đến một phần tử ở trong class
     * thể hiện qua Access Modifier (AM). trong C# có các loại AM sau
     * public: Truy cập được ở mọi nơi
     * private: Chỉ truy cập được trong phạm vi class chứ nó
     * protected: Chỉ truy cập được trong phạm vi class và các class kế thừa từ nó
     * internal: Phạm vi truy cập nằm trong cùng 1 assembly (Project)
     * protected internal: protected + internal (quan hệ hoặc): Nằm trong cùng 1
     * assembly (Project) hoặc nằm trong cùng class và các class kế thừa
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Sinhvien sv = new Sinhvien(); // Khởi tạo
            // Gán giá trị cho các thuộc tính
            //sv.MaSv = "PH13";
            sv.TenSv = "Khánh Pigi";
            //sv.Khoa = 19;
            sv.Dob = DateTime.Now;
            sv.Nganh = "UDPM";
            sv.InThongTin();
            Console.ReadKey();
        }
    }
}
