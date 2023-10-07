using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_4TC_OOP_2
{
    internal interface Toipham
    {
        /* Trong lập trình C#. Interface được tạo ra với
         * ý nghĩa của sự trừu tượng hoàn toàn
         * tất cả các phương thức trong interface đều là
         * phương thức ảo nhưng không cần có từ khóa abstract
         * Interface được sinh ra để giải quyết vấn đề đa kế 
         * thừa nghĩa là 1 class chỉ kế thừa được 1 class cha 
         * nhưng có thể kế thừa vô số interface
         */
        void Xinchao();

    }
}
