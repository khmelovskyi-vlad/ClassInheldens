using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Bee : Insects, IWalking, IFlyable
    {
        public Bee(double weight, string name)
            :base(weight,name,true)
        {

        }

        public void Fly(double range)
        {
            throw new NotImplementedException();
        }

        public void Walk(double range)
        {
            throw new NotImplementedException();
        }
    }
}
