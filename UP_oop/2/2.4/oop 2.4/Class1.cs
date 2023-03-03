using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2._4
{
    public class reduce
    {
        public int counter { get; set; }

        public reduce()
        {
            counter = 7;
        }

        public void CounterInfo()
        {
            Console.WriteLine("Значение счетчика: " + counter + "\n");
        }
    }
}