using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi12_Luyentap_List_OOP
{
    internal class Giaovien
    {
        int id;
        string ten;
        double sogioday;
        public Giaovien()  {  }
        public Giaovien(int id, string ten, double sogioday)
        {
            this.Id = id;
            this.Ten = ten;
            this.Sogioday = sogioday;
        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Sogioday { get => sogioday; set => sogioday = value; }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {id}, Tên: {ten}, dạy {sogioday} giờ");
        }
    }
}
