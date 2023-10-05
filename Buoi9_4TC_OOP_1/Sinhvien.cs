using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9_4TC_OOP_1
{
    internal class Sinhvien
    {
        // Khai báo các thuộc tính
        string maSv;
        string tenSv;
        int khoa;
        DateTime dob; // Ngày sinh - date of birth
        string nganh;
        // Constructor
        public Sinhvien(){}
        public Sinhvien(string maSv, string tenSv, int khoa, DateTime dob, string nganh)
        {
            this.MaSv = maSv;
            this.TenSv = tenSv;
            this.Khoa = khoa;
            this.Dob = dob;
            this.Nganh = nganh;
        }
        // trong class C#, AM mặc định là private
        private string MaSv { get => maSv; set => maSv = value; }
        internal string TenSv { get => tenSv; set => tenSv = value; }
        protected int Khoa { get => khoa; set => khoa = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        protected internal string Nganh { get => nganh; set => nganh = value; }
        public void InThongTin()
        {
            Console.WriteLine($"Tên: {TenSv}, Mã: {MaSv}, Khóa {khoa}" +
                $"Ngày sinh: {dob}, Ngành {nganh}");
        }
    }
}
