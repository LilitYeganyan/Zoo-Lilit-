using System.Collections.Generic;

namespace Zoo_Lilit_
{
    class Employee
    {
        private List<FoodType> FoodSupply = new List<FoodType> { FoodType.Gress, FoodType.Meat, FoodType.Milk, FoodType.Worm };
        public Employee() { }

       
        public void FeedAnimal(Cage cage, Food food)
        {
            cage.AddFoodinContainer(food);
        }
    }
}
