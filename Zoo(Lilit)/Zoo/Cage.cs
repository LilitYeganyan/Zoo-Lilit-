using System.Collections.Generic;

namespace Zoo_Lilit_
{
    internal delegate void CageGuard(Food food);
    class Cage
    {
        internal event CageGuard TheFoodWereSet;
       // internal Food AFood { get; set; }
        internal List<Animal> animalList;
        internal Container AnimalContainer { get; set; }
        internal Employee CageEmployee { get; set; }
        internal AnimalType Type { get; set; }
        public Cage()
        {
           // this.AFood = new Food();
            this.animalList = new List<Animal>();
            //this.AnimalContainer = new Container();
        }
        public void Add(Animal animal)
        {
            animalList.Add(animal);
            //animal.FolloweEvent(this);
        }

        internal void AddFoodinContainer(Food food)
        {
            AnimalContainer.food = food;
            TheFoodWereSet.Invoke(food);

        }

    }
}
