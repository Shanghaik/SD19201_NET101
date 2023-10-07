using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal class Chota : Concho
    {
        public override void Chay(int tinhhuong)
        {
            if(tinhhuong == 1)
            {
                Console.WriteLine("Phi như điên nhưng tìm thức ăn đã giấu");
            }else if(tinhhuong == 2)
            {
                Console.WriteLine("Vẫn đuổi cho đến khi bị dọa");
            }
            else Console.WriteLine("Chạy lông nhông đi chơi quên lối về");
        }
    }
}
