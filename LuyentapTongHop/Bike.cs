using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTongHop
{
    internal class Bike
    {
        int id;
        string ten;
        string hangSx;
        string matusinh = TuSinhMa(); // Mã tự sinh có 4 kí tự Chữ cái A-Z
        public Bike()
        {
            matusinh = TuSinhMa();
        }
        public Bike(int id, string ten, string hangSx)
        {
            this.Id = id;
            this.Ten = ten;
            this.HangSx = hangSx;
            matusinh = TuSinhMa();
        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string HangSx { get => hangSx; set => hangSx = value; }
        public string Matusinh { get => matusinh; set => matusinh = value; }
        public static string TuSinhMa()
        {
            string randomStr = "";
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
               char x = (char)r.Next(65, 90); // Phương thức này random ra 1 giá trị, sau đó từ giá trị đó ta ép kiểu
                // về char (Theo thứ tự trong bảng mã ASCII
                randomStr+= x;
            }
            return randomStr;
        }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {id}, tên: {ten}, Hãng: {HangSx}, Mã tự sinh {matusinh}");
        }
    }
}
