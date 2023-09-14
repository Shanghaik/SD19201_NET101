using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_HelloWorld_14_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set OutEncoding = Unicode để kết quả đầu ra
            // là kí tự Unicode
            Console.OutputEncoding = Encoding.Unicode;
            //Gõ câu lệnh đầu tiên - in ra helloworld
            Console.WriteLine("Hello world"); // cw + tab + tab
            Console.WriteLine("Xin chào tất cả các bạn!!");
            Console.WriteLine("Xin chào, tôi là Khánh Pi Gi," +
                "Tôi năm nay 20 tuổi, chưa có người yêu nhưng " +
                "đã có vợ con");
            // Xuống dòng trên code khác với xuống dòng ở string
            // cần kí tự \n mới là xuống dòng   
        }
    }
}
