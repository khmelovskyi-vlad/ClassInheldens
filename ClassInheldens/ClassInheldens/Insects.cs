using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Insects : Arthropods
    {
        public Insects(double weight, string name, bool community)
            :base(weight,name,3)
        {
            this.Сommunity = community;
        }
        public bool Сommunity { get; set; }
    }
}
