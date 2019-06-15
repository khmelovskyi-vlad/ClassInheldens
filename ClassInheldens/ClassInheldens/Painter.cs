using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Painter: Vertebrates
    {
        public Painter(double weight, string name)
            :base(weight, name, 4)
        {

        }
    }
}
