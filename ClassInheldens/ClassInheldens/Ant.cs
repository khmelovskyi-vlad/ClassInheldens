using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Ant : Insects, IWalking
    {
        public Ant(double weight, string name)
            : base(weight, name, false)
        {

        }

        public void Walk(double range)
        {
            throw new NotImplementedException();
        }
    }
}
}
