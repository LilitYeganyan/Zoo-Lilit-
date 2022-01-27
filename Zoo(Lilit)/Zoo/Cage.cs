using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    internal delegate void CageGuard(Food food);
    class Cage
    {
        internal event CageGuard TheFoodWereSet;
        internal List<Animal> animalList;
        internal Container AnimalContainer { get; set; }
        public Cage()
        {
            this.animalList = new List<Animal>();
            this.AnimalContainer = new Container();
        }

        public void Add(Animal animal)
        {
            animalList.Add(animal);
        }

        private void AnimalisEating(Food food)
        {
            foreach (Animal animal in animalList)
            {
                animal.Eat(AnimalContainer.food);
            }
        }
       
    }
}
