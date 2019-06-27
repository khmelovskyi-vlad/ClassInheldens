using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Bee : Insects, IWalking, IFlyable, IPollination
    {
        public Bee(double weight, string name)
            :base(weight,name,true)
        {

        }
        public int countPollinate = 0;
        public void Pollinate(int count) => countPollinate = count;
        public double flyDistance = 0;
        public void Fly(double range) => flyDistance = range;
        public double walkDistance = 0;
        public void Walk(double range) => walkDistance = range;
        public override void Eat(string nameEat, double weightEat)
        {
            var oldWeight = weightEat;
            if (nameEat == "meat")
            {
                Weight += weightEat*1.1;
                LastEatType = nameEat;
            }
            else if (nameEat == "cake")
            {
                Weight += weightEat*1.05;
                LastEatType = nameEat;
            }
            else if (nameEat == "sweet")
            {
                Weight += weightEat*1.1;
                LastEatType = nameEat;
            }
            else if (nameEat == "pollen")
            {
                Weight += weightEat;
                LastEatType = nameEat;
            }
            else if (nameEat == "honey")
            {
                LastEatType = "die";
            }
                LastEatWeight = weightEat;
            
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen") && (LastEatWeight < Weight/2 && LastEatWeight > Weight / 10) && (flyDistance>5) && (walkDistance<0.05) && (countPollinate > 20);
            }
        }
    }
}
