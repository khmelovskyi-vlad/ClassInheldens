using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Arthropods:Animal
    {
        public Arthropods(double weight, string name, int dickCount)
            : base(weight, name)
        {
            this.DickCount = dickCount;
        }
        protected int LastEatWeight = 10;
        protected string LastEatType = "dgf";
        public override bool Peaces
        {
            get
            {
                return LastEatType == "meat" && LastEatWeight > 10;
            }
        }
        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;
            }
            else if (nameEat == "aslfh")
            {
                LastEatType = "Bobick dovolen";
            }
        }
        public int DickCount { get; set; }
    }
}
