using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal abstract class Ca 
    {
        // abstract là class ảo - trừu tượng nhưng không hoàn toàn
        // vẫn có thể có các phương thức không trừu tượng trong lớp này
        // abstract - ảo
        public Ca()
        {
        }
        // Phương thức ảo là phương thực thuộc lớp ảo và không có thân
        // Để được triển khai thì phương thức này bắt buộc phải được
        // override lại ở các lớp dẫn xuất (được kế thừa)
        public abstract void Boi();
        public void Song()
        {
            Console.WriteLine("Cá hầu hết sống dưới nước");
        }
        public abstract void An();


    }
}
