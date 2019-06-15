using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Сrustaceans : Arthropods
    {
        public Сrustaceans(double weight, string name, int fadeRade)
            :base(weight,name,3)
        {
            this.FadeRade = fadeRade;
        }
        public int FadeRade { get; set; }

        public override void Eat(string nameEat, double weightEat)
        {
            if (nameEat == "meat")
            {
                Weight += weightEat;

            }
        }
    }
}
