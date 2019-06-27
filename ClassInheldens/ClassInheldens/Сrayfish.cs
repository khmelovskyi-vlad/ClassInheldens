using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Сrayfish : Сrustaceans, ISwimmable, IWalking
    {
        public Сrayfish(double weight, string name, int fadeRade)
            : base(weight, name, fadeRade)
        {

        }
        public double swimDistance = 0;
        public void Swim(double range) => swimDistance = range;
        public double walkDistance = 0;
        public void Walk(double range) => walkDistance = range;
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
                LastEatType = nameEat;
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
            else if (nameEat == "fish")
            {
                Weight += weightEat*0.9;
                LastEatType = nameEat;
            }
            else if (nameEat == "wolf")
            {
                LastEatType = nameEat;
            }
                LastEatWeight = weightEat;
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "fish" || LastEatType == "wolf") && (LastEatWeight < Weight / 2 && LastEatWeight > Weight / 10) && (walkDistance < 0.5) && (swimDistance > 3);
            }
        }
    }
}


