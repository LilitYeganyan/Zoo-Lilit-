using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Employee 
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        private List<Food> FoodSupply = new List<Food> { Food.Gress, Food.Meat, Food.Milk, Food.Worm };
        public Employee() { }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void FeedAnimal(Cage cage)
        {
            for(int i=0; i<FoodSupply.Count; i++)
            {
                cage.AddFoodinContainer(FoodSupply[i]);
            }          
        }
    }
}
