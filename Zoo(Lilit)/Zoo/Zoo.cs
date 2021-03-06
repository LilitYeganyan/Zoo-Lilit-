using System.Collections.Generic;

namespace Zoo_Lilit_
{
    class Zoo
    {
        private Employee Person { get; set; }
        private List<Cage> AnimalsCage { get; set; }

        Fox fox = new Fox("Fox", 15, 20);
        Eagle eagle = new Eagle("Eagle", 7, 15);
        Bee bee = new Bee("Bee", 2, 5);
        Chameleon chameleon = new Chameleon("Chameleon", 9, 11);
        public Zoo()
        {
            this.AnimalsCage = new List<Cage>(3);
            AnimalsCage[0].Type = AnimalType.Mammal;
            AnimalsCage[1].Type = AnimalType.Bird;
            AnimalsCage[2].Type = AnimalType.Reptile;
            AnimalsCage[3].Type = AnimalType.Insect;
        }

        public void AddAnimalInCage(Animal animal)
        {
            if (animal is Mammal)
            {
                AnimalsCage[0].Add(animal);
            }
            if (animal is Bird)
            {
                AnimalsCage[1].Add(animal);
            }
            if (animal is Reptile)
            {
                AnimalsCage[2].Add(animal);
            }
            else if (animal is Insect)
            {
                AnimalsCage[3].Add(animal);
            }
        }

        public void ZooAnimals()
        {
            AddAnimalInCage(fox);
            AddAnimalInCage(eagle);
            AddAnimalInCage(bee);
            AddAnimalInCage(chameleon);
        }
        public void FeedingProcess(Food food)
        {
            for (int i = 0; i < AnimalsCage.Count; i++)
            {
                Person.FeedAnimal(AnimalsCage[i], food);
            }
        }

    }
}
