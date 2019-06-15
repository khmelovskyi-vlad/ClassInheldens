using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Bird : Vertebrates
    {
        public Bird(double weight, string name)
            : base(weight, name, 4)
        {

        }
    }
}
