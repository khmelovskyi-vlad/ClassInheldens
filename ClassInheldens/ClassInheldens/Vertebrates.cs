using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Vertebrates : Animal
    {
        public Vertebrates(double weight, string name, int limbCount)
            :base (weight,name)
        {
            this.LimbCount = limbCount;
        }
        public int LimbCount { get; set; }
    }
}
