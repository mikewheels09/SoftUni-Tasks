﻿namespace _03.WildFarm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        protected Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.livingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this.livingRegion; }
            set { this.livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
