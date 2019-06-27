using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Duck : Bird, IFlyable, ISwimmable, IWalking
    {
        public Duck(double weight, string name)
            :base(weight,name)
        {

        }
        public double flyDistance = 0;
        public void Fly(double range) => flyDistance = range;
        public double swimDistance = 0;
        public void Swim(double range) => swimDistance = range;
        public double walkDistance = 0;
        public void Walk(double range) => walkDistance = range;
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = "hannibal";
            }
            else if (nameEat == "cake")
            {
                Weight += weightEat * 1.04;
                LastEatType = nameEat;
            }
            else if (nameEat == "sweet")
            {
                Weight += weightEat * 1.1;
                LastEatType = nameEat;
            }
            else if (nameEat == "mandarin")
            {
                Weight += weightEat;
                LastEatType = nameEat;
            }
            else if (nameEat == "Sprats")
            {
                LastEatType = "die";
            }
                LastEatWeight = weightEat;
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "mandarin" || LastEatType == "hannibal") && (LastEatWeight < Weight / 2 && LastEatWeight > Weight / 10) && (walkDistance < 0.5) && (swimDistance < 0.5) && (flyDistance > 10);
            }
        }
    }
}