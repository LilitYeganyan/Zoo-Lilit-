using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Food
    {
        public int mass;
        private List<FoodType> FoodList = new List<FoodType>() { FoodType.Gress, FoodType.Meat, FoodType.Milk, FoodType.Worm };
        public int Mass
        {
            get
            {
                return this.mass;
            }

            set
            {
                if (value < 0)
                {
                    this.mass = 0;
                }
                else
                {
                    value = this.mass;
                }
            }
        }

        public List<FoodType> FeedbyType(Animal animal, Food food)
        {
            List<FoodType> FoodForHerbivorous = new List<FoodType>() { FoodType.Gress, FoodType.Milk };
            List<FoodType> FoodForPredator = new List<FoodType>() { FoodType.Meat, FoodType.Milk, FoodType.Worm };
            if (animal.FType is TypeByFood.Herbivorous)
            {
                this.FoodList = FoodForHerbivorous;

            }
            else if (animal.FType is TypeByFood.Predator)
            {
                this.FoodList = FoodForPredator;
            }
            return this.FoodList;
        }
    }
}
