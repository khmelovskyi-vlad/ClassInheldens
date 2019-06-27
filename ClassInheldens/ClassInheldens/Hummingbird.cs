using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Hummingbird : Bird, IFlyable, IWalking
    {
        public Hummingbird(double weight, string name)
            : base(weight, name)
        {

        }
        public double flyDistance = 20;
        public void Fly(double range) => range = flyDistance;
        public double walkDistance = 20;
        public void Walk(double range) => range = walkDistance;
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = "Bed input, try again";
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
            else if (nameEat == "pollen")
            {
                Weight += weightEat;
                LastEatType = nameEat;
            }
            else if (nameEat == "honey")
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
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen" || LastEatType == "honey") && (LastEatWeight < Weight / 2 || LastEatWeight > Weight / 10) && (walkDistance > 0.5) && (flyDistance < 10);
            }
        }
    }
}

