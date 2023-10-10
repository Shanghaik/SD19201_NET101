using System;
using System.Collections;
//using System.Collections; // non-generic 
using System.Collections.Generic;// generic 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi11_Collection
{
    internal class Program
    {
        // Trong lập trình C#, ngoài các kiểu dữ liệu cơ bản hoặc mảng,
        // chúng ta còn được cung cấp các lớp collection để thực hiện việc
        // lưu trữ và quản lý dữ liệu một cách hiệu quả
        // Giống với mảng thì collection lưu trữ được nhiều phần tử
        // Có 2 loại collection chính là Generic và non-Generic
        // Genreric collection cho phép chúng ta lưu trữ các phần tử thuộc
        // cùng kiểu dữ liệu nhưng có thể lưu trữ các dữ liệu thuộc nhiều
        // kiểu dữ liệu khác nhau và không thể thay đổi
        // non-Generic collection cho phép ta lưu trữ các phần tử khác kiểu
        // dữ liệu và nhận mọi kiểu dữ liệu
        static void Main(string[] args)
        {
            // Đại diện cho non-Generic collection là ArrayList
            //ArrayList arrayList = new ArrayList();
            //// Thêm phần tử vào cuối
            //arrayList.Add(1); arrayList.Add("ABC");
            //arrayList.Add(new double[] { 1, 2, 3, 4, 5 });
            // Ta có thể truy xuất đến các phần tử trong arrayList như với mảng
            // Bằng cách sử dụng chỉ số
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //// Đại diện cho Generic collection là List
            //List<int> listInt = new List<int>();
            //listInt.Add(1); listInt.Add(600);
            //listInt.Add(200);
            //foreach (int i in listInt)
            //{
            //    Console.WriteLine(i);
            //}
            //List<string> listString = new List<string>();
            //listString.Add("1a"); 
            //listString.Add("2b"); listString.Add("3c");
            //listString.Add("4d"); listString.Add("5e");
            //for (int i = 0; i < listString.Count; i++)
            //{
            //    Console.WriteLine(i+": "+listString[i]);
            //}
            //Console.WriteLine();
            // Với collection chúng ta con rất nhiều phương thức
            // listString.Sort(); 
            // Sắp xếp - thường chỉ hoạt động đúng cho các kiểu dữ liệu cơ bản

            // listString.Clear(); // Xóa sạch
            //listString.RemoveAt(1); // Xóa theo vị trí số 1
            //for (int i = 0; i < listString.Count; i++)
            //{
            //    Console.WriteLine(i + ": " + listString[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine(listString.Remove("4e"));// trả về bool
            //for (int i = 0; i < listString.Count; i++)
            //{
            //    Console.WriteLine(i + ": " + listString[i]);
            //}
            //listString.RemoveRange(1, 2);// xóa từ số 1 và xóa 2 phần tử
            //Console.WriteLine();
            //for (int i = 0; i < listString.Count; i++)
            //{
            //    Console.WriteLine(i + ": " + listString[i]);
            //}
            // Kiểm tra vị trí IndexOf và LastIndexOf
            //Console.WriteLine(listString.IndexOf("1a")); // vị trí đầu tiên của 1a
            //Console.WriteLine(listString.IndexOf("1b")); // trả về -1 nếu không có
            //Console.WriteLine(listString.LastIndexOf("1a"));// vị trí cuối của 1a
            List<ChaiNuoc> chaiNuocs = new List<ChaiNuoc>();
            ChaiNuoc cn1 = new ChaiNuoc("Coca 1.5", "Cocacola");
            ChaiNuoc cn2 = new ChaiNuoc("Coca 350", "Cocacola");
            ChaiNuoc cn3 = new ChaiNuoc("Pepsi 2.25", "PepsiCo");
            ChaiNuoc cn4 = new ChaiNuoc("Lays", "PepsiCo");
            ChaiNuoc cn5 = new ChaiNuoc("Mirinda", "PepsiCo");
            chaiNuocs.Add(cn1); chaiNuocs.Add(cn2); 
            chaiNuocs.Add(cn3); chaiNuocs.Add(cn4); chaiNuocs.Add(cn5);
            // In danh sách ra
            foreach (var item in chaiNuocs)
            {
                item.InThongTin();
            }
            Console.ReadKey();
        }
    }

    public class ChaiNuoc
    {
        string ten;
        string hang;
        public ChaiNuoc() { }
        public ChaiNuoc(string ten, string hang)
        {
            this.Ten = ten;
            this.Hang = hang;
        }
        public string Ten { get => ten; set => ten = value; }
        public string Hang { get => hang; set => hang = value; }
        public void InThongTin()
        {
            Console.WriteLine($"Tên : {ten}, hãng: {hang}");
        }
    }
    // Mẫu class mà không có các thuộc tính, sử dụng thẳng property
    public class CaiCoc
    {
        public string Ten { get; set; } // prop tab tab
        public int Dungtich { get; set; }
        public CaiCoc() { }
        public CaiCoc(string ten, int dungtich)
        {
            Ten = ten;
            Dungtich = dungtich;
        }
    }
}
