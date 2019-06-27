﻿using System;
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
        public double flyDistance = 20;
        public void Fly(double range) => range = flyDistance;
        public double walkDistance = 20;
        public void Walk(double range) => range = walkDistance;
        public override void Eat(string nameEat, double weightEat)
        {       
            if (nameEat == "meat")
            {
                Weight -= weightEat*1.4;
                LastEatType = nameEat;
            }
            else if (nameEat == "cake")
            {
                Weight += weightEat*1.5;
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
            else if (weightEat > Weight / 2)
            {
                LastEatWeight = weightEat;
            }
        }
        public override bool Peaces
        {
            get
            {
                return (LastEatType == "meat" || LastEatType == "cake" || LastEatType == "sweet" || LastEatType == "pollen") && (LastEatWeight < Weight/2 || LastEatWeight > Weight/10) && (flyDistance>5) && (walkDistance>1);
            }
        }
    }
}
