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

        public Employee() { }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        internal void AddFoodinfContainer(Cage cage, Food food)
        {
            cage.AnimalContainer.food = food;
        }
    }
}
