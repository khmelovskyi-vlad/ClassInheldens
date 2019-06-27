using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Crab : Сrustaceans, ISwimmable, IWalking, IPikUpStick
    {
        public Crab(double weight, string name, int fadeRade)
            : base(weight, name, fadeRade)
        {
        }
        public int stickCount = 0;
        public void Stick(int count) => stickCount = count;
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
            else if (nameEat == "kiwi")
            {
                Weight += weightEat;
                LastEatType = nameEat;
            }
            else if (nameEat == "vodka")
            {
                LastEatType = "cake";
            }
                LastEatWeight = weightEat;
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen") && (LastEatWeight < Weight / 2 && LastEatWeight > Weight / 10) && (walkDistance < 1) && (swimDistance > 3) && (stickCount>20);
            }
        }
    }
}

