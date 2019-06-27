using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    class Ant : Insects, IWalking, IPikUpStick
    {
        public Ant(double weight, string name)
            : base(weight, name, false)
        {

        }
        public int stickCount = 0;
        public void Stick(int count) => stickCount = count;
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
                Weight += weightEat * 1.05;
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
                LastEatType = "die";
            }
                LastEatWeight = weightEat;
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen") && (LastEatWeight < Weight / 2 && LastEatWeight > Weight / 10) && (walkDistance < 1) && (stickCount>15);
            }
        }
    }
}