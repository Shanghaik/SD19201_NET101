using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal class Camap : Ca
    {
        public override void An()
        {
            Console.WriteLine("Cá mập ăn thịt");
        }

        public override void Boi()
        {
            Console.WriteLine("Cá mập bơi lắc đít");
        }
    }
    internal class Cavoi : Ca
    {
        public override void An()
        {
            Console.WriteLine("Cá voi ăn phù du");
        }

        public override void Boi()
        {
            Console.WriteLine("Cá voi bơi bằng 4 chi");
        }
    }
}
