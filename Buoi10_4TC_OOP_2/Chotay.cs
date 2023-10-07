using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal class Chotay : Concho
    {
        public override void Chay(int tinhhuong)
        {
            if (tinhhuong == 1)
            {
                Console.WriteLine("Phi như điên tìm chủ");
            }
            else if (tinhhuong == 2)
            {
                Console.WriteLine("Đuổi 1 chút xong sủa");
            }
            else Console.WriteLine("Ở nhà nằm ngủ, bọn này nó lười");
        }
    }
}
