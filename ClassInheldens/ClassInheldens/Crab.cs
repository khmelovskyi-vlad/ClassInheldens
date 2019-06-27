using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Crab : Сrustaceans, ISwimmable, IWalking
    {
        public Crab(double weight, string name, int fadeRade)
            : base(weight, name, fadeRade)
        {
        }
        public double swimDistance = 20;
        public void Swim(double range) => range = swimDistance;
        public double walkDistance = 20;
        public void Walk(double range) => range = walkDistance;
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = nameEat;
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
            else if (nameEat == "kiwi")
            {
                Weight += weightEat;
                LastEatType = nameEat;
            }
            else if (nameEat == "vodka")
            {
                LastEatType = "cake";
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
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen") && (LastEatWeight < Weight / 2 || LastEatWeight > Weight / 10) && (walkDistance > 1);
            }
        }
    }
}

