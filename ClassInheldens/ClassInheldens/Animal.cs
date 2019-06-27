using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheldens
{
    abstract class Animal
    {
        public Animal(double weight, string name)
        {
            this.Weight = weight;
            this.Name = name;
        }
        public abstract bool Peaces { get; } 
        public double Weight { get; set; }
        public string Name { get; set; }
        public abstract void Eat(string nameEat, double weightEat);
        protected double LastEatWeight = 0;
        protected string LastEatType = "";
    }
}
