using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_ToanTu_CaulenhDieukien
{

    /*
     * Toán tử là hệ thống kí hiệu được sử dụng để thực hiện
     * các phép tính, biến đổi để cho ra kết quả.
     * Toán tử luôn đi kèm với các giá trị.
     * Có nhiều cách để phân loại toán tử như theo chức năng
     * (Số học, Quan hệ, Logic,...)
     * Theo số ngôi (Là số lượng giá trị cần có để thực hiện)
     * VD phép tính A+B cần 2 giá trị thì phép + là 2 ngôi
     * !A - Phủ định của A, A++ - Tăng A lên 1 đơn vị,...
     */
    /*
     * Câu lệnh điều kiện - rẽ nhánh là những cú pháp cho phép ta xử lý và
     * đưa ra kết quả theo từng điều kiện của một biểu thức điều kiện nào đó
     * VD khi có 2 số nguyên a và b ta có thể thực hiện phép so sánh
     * sẽ có tối thiểu 3 trường hợp a > b, a < b và a = b
     * Các loại câu lệnh điều kiện thông thường hay được sử dụng bao gồm:
     * If-else, switch-case, toán tử 3 ngôi
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập và tính kết quả của phép +, -, *, /, %, ^ (mũ)
            // 2 số nguyên a và b
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhập b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"a + b = {a + b}");
            //Console.WriteLine($"a - b = {a - b}");
            //Console.WriteLine($"a * b = {a * b}");
            //Console.WriteLine($"a / b = {a * 1.0 / b}");
            //Console.WriteLine($"a % b = {a % b}");
            //Console.WriteLine($"a ^ b = {Math.Pow(a, b)}");
            //// Căn bậc b của a = a ^ (1/b)
            //Console.WriteLine($"căn bậc {b} của {a} = {Math.Pow(a, 1.0 / b)}");
            // Bài 2: Nhập 2 số nguyên và toán tử, sau đó tính kết quả (if - else)
            // vd nhập a = 4, b = 5, toán tử là + thì ra 9, toán tử là string
            //Console.WriteLine("Nhập toán tử: ");
            //string toantu = Console.ReadLine();
            //if (toantu == "+") { Console.WriteLine($"a + b = {a + b}"); }
            //else if (toantu == "-") { Console.WriteLine($"a - b = {a - b}"); }
            //else if (toantu == "*") { Console.WriteLine($"a * b = {a * b}"); }
            //else if (toantu == "/") { Console.WriteLine($"a / b = {a / b}"); }
            //else if (toantu == "%") { Console.WriteLine($"a % b = {a % b}"); }
            //else if (toantu == "-") { Console.WriteLine($"a ^ b = {a ^ b}"); }
            //else Console.WriteLine($"căn bậc {b} của {a} " +
            //    $"= {Math.Pow(a, 1.0 / b)}");
            Console.WriteLine("Nhập x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập y:");
            int y = Convert.ToInt32(Console.ReadLine());
            //if (x > y)
            //{
            //    Console.WriteLine($"{x} > {y}");
            //}
            //else if (x < y)
            //{
            //    Console.WriteLine($"{x} < {y}");
            //}
            //else { Console.WriteLine($"{x} = {y}"); }
            // Nhập 3 số x y z, tìm ra số lớn nhất trong 3 số đó
            // Nhập 3 số x y z, tìm ra số lớn thứ 2 trong 3 số đó
            // dùng && để kết hợp đk đồng thời, || để kết hợp đk hoặc
            Console.WriteLine("Nhập z:");
            int z = Convert.ToInt32(Console.ReadLine());
            if (x >= y && x >= z)
            {
                Console.WriteLine($"{x} lớn nhất");
            }
            else if (y >= z) // Chỉ cần so sánh y và z vì x đã so sánh rồi
            {
                Console.WriteLine($"{y} lớn nhất");
            }
            else Console.WriteLine($"{z} lớn nhất");
            // Cách 2 dùng toán tử 3 ngôi
            // VD cách dùng: so sánh x và y
            int more = x >= y ? x : y; // So sánh x và y, nếu x lớn
            // hơn thì more = x ngược lại thì = y
            // điều kiện ? giá trị nếu dk đúng : giá trị nếu đk sai
            Console.WriteLine(more);
            // Áp dụng 3 ngôi để tìm số lớn nhất
            int max = x >= y && x >= z ? x : (y >= z ? y : z);
            Console.WriteLine("Max là " + max);
            // Tìm số lớn thứ 2 trong 3 số
            // Cách 1: Dùng if-else
            if (x >= y && x <= z || x <= y && x >= z)
            {
                Console.WriteLine(x + " là số lớn thứ 2");
            }
            else if (y >= x && y <= z || y >= z && y <= x)
            {
                Console.WriteLine(y + " là số lớn thứ 2");
            }
            else Console.WriteLine(z + " là số lớn thứ 2");
            // Cách 2: Tìm max, tìm min sau đó lấy tổng 3 số trừ max - min
            int min = x <= y && x <= z ? x : (y <= z ? y : z);
            Console.WriteLine((x + y + z - max - min) + " là số lớn thứ 2");
            // Cách 3: Sử dụng tính chất của số lớn thứ 2
            int second = (x - y) * (x - z) <= 0 ? x : (y - z) * (y - x) <= 0 ? y : z;
            Console.WriteLine(second + " là số lớn thứ 2 =))");
            // Phân tích cách 3: Số lớn nhất nếu trừ đi 2 số còn lại => Dương
            // Số bé nhất trừ đi 2 số còn lại => âm
            // Chỉ có số thứ 2 trừ đi 2 số còn lại thì ra 2 kết quả trái dấu
            // tích của 2 kết quả đó luôn <= 0 
        }
    }
}
