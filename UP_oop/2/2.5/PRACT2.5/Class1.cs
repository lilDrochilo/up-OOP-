using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace PRACT2._5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace uchPractical5
    {
        public class Del
        {
            private int a;
            private int b;

            public int A
            {
                get => this.a;
                set => this.a = value;
            }

            public int B
            {
                get => this.b;
                set => this.b = value;
            }
            public Del(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public Del()
            {
                a = 555;
                b = 2222;
            }

            ~Del()
            {
                Console.Write($"{a} has been deleted\n");
                Console.Write($"{b} has been deleted");
            }
        }
    }
}
