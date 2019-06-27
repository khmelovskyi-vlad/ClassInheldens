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
        public double flyDistance = 20;
        public void Fly(double range) => range = flyDistance;
        public double swimDistance = 20;
        public void Swim(double range) => range = swimDistance;
        public double walkDistance = 20;
        public void Walk(double range) => range = walkDistance;
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = "hannibal";
            }
            else if (nameEat == "cake")
            {
                Weight += weightEat * 1.4;
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
            else if (weightEat > Weight * 0.75)
            {
                LastEatWeight = weightEat;
            }
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "mandarin" || LastEatType == "hannibal") && (LastEatWeight < Weight / 2 || LastEatWeight > Weight / 10) && (walkDistance > 0.5) && (swimDistance < 5) && (flyDistance < 10);
            }
        }
    }
}