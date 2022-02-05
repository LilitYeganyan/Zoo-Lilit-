using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    internal delegate void CageGuard();
    class Cage
    {
        internal event CageGuard TheFoodWereSet;
        internal List<Animal> animalList;
        internal Container AnimalContainer { get; set; }
        internal Employee CageEmployee { get; set; }
        internal AnimalType Type { get; set; }
        public Cage()
        {
            this.animalList = new List<Animal>();
            //this.AnimalContainer = new Container();
        }
        public void Add(Animal animal)
        {
            animalList.Add(animal);
            animal.FolloweEvent(this);
        }

        internal void AddFoodinContainer(Food food)
        {
            AnimalContainer.food = food;
            TheFoodWereSet.Invoke();

        }

    }
}
