using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_ChuaLab
{
    internal class Program
    {
        static void Cau1() // Nhập xuất thông tin cá nhân
        {
            Console.WriteLine("Enter your Personal Information:");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine($"Name: {name}, age: {age}, address: {address}");
        }
        static int Cau2() // Nhập và tính tuổi người yêu cũ
        {
            Console.WriteLine("Enter your ex's birth year: ");
            int birth = Convert.ToInt32(Console.ReadLine());
            return DateTime.Now.Year - birth;
        }
        static void Cau3() // Nhập 3 số và tìm số lớn thứ 2
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            // Cách 4 dùng hàm có sẵn thông qua max, min
            int max2 = Math.Min(Math.Max(a, b), Math.Max(a, c));
            Console.WriteLine("The second highest number is: " + max2);
        }
        static int Cau4()
        {
            int count = 0; // đếm số thành viên khi nhập
            string[] names = new string[1000]; // Không nên dùng, sau này dùng list // comment khi chạy list
            // List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter member's name");
                names[count++] = Console.ReadLine(); // sau khi nhập thì count tăng // comment khi chạy list
                // names.Add(Console.ReadLine());
                Console.WriteLine("Do you want to stop? Y/N");
                string choose = Console.ReadLine();
                if (choose == "Y") break;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(names[i] + " ");
            }
            return count;
        }
        static void Cau5_PrimeNumber()
        {
            Console.WriteLine("Enter the number you want to check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 2) { Console.WriteLine($"{number} is not a Prime Number"); }
            else
            {
                bool check = true;
                for (int i = 2; i*i <= number; i++)// i*i <= number <=> i<= Math.Sqrt(number)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{number} not a Prime Number");
                        check = false;
                    }

                }
                if(check) Console.WriteLine($"{number} is a Prime Number");
            }
        }
        /*
         * Nếu a chia hết cho b mà b < căn bậc 2 của a
            thì GS kết quả là c thì c > căn bậc 2 của a
            vì nếu cả b và c < căn bậc 2 của a thì
            tích 2 số < căn bậc 2 của a => vô lý
         */
        static void Cau5_DoubleInterest() // Lãi kép theo tháng
        {
            Console.WriteLine("Enter your start money: ");
            long money = Convert.ToInt64(Console.ReadLine()); // Số tiền khỏi điểm
            Console.WriteLine("Enter your Interest Percent: ");
            double interestPercent = Convert.ToDouble(Console.ReadLine()); // Tỉ lệ lại theo %
            Console.WriteLine("Enter the number of month you loan");
            int month = Convert.ToInt32(Console.ReadLine()); // Số tháng vay
            long interest = (long)(money * Math.Pow((1 + interestPercent / 100), month)) - money;
            Console.WriteLine($"You have to pay {interest} to avoid being prisioner");
        }
        static void Main(string[] args)
        {
            //Cau3();
            //Console.WriteLine("The number of member you entered is : " + Cau4());
            //Cau5_PrimeNumber();
            Cau5_DoubleInterest();
            Console.ReadKey();
        }
    }
}
