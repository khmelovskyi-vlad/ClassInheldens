using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Hummingbird : Bird, IFlyable, IWalking, IPollination
    {
        public Hummingbird(double weight, string name)
            : base(weight, name)
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
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = "Bed input, try again";
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
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen" || LastEatType == "honey") && (LastEatWeight < Weight / 2 && LastEatWeight > Weight / 10) && (walkDistance < 0.5) && (flyDistance > 7) && (countPollinate > 15);
            }
        }
    }
}

