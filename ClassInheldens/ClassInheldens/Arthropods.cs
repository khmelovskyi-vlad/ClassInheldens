using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Arthropods:Animal
    {
        public Arthropods(double weight, string name, int dickCount)
            : base(weight, name)
        {
            this.DickCount = dickCount;
        }
        public int DickCount { get; set; }
    }
}
