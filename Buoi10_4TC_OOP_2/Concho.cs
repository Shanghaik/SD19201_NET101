using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal class Concho
    {
        string ten;
        string loai;
        string maulong;
        int tuoi;
        public Concho()// ctor
        {
        }
        public Concho(string ten, string loai, string maulong, int tuoi)
        {
            this.ten = ten;
            this.loai = loai;
            this.maulong = maulong;
            this.tuoi = tuoi;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public string Maulong { get => maulong; set => maulong = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public void Chay()
        {
            Console.WriteLine("Chó chạy lông nhông");
        }
        public virtual void Chay(int tinhhuong)
        {
            if(tinhhuong == 1) 
            {
                Console.WriteLine("Phi như điên đi tìm thức ăn");
            }
            else if(tinhhuong == 2) 
            {
                Console.WriteLine("Tham dự trò chơi chọc chó");
            }else Console.WriteLine("Thấy con chó nhà hàng xóm");
        }
    }
}
