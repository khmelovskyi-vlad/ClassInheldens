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
        public override bool Peaces
        {
            get
            {
                return LastEatType == "meat" || LastEatWeight > 10;
            }
        }
        public int DickCount { get; set; }
    }
}
