using System;
using System.Collections.Generic;
using System.Timers;

namespace Zoo_Lilit_
{
    class Chameleon : Reptile
    {
        public Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        public Chameleon(string name, int Age, int Stomach) : base(name, Age, Stomach)
        {
            this.FType = TypeByFood.Predator;
            this.FoodList = new List<FoodType> { FoodType.Meat, FoodType.Worm };
            Time();
            this.ACage.Type = AnimalType.Reptile;
        }
        public void Time()
        {
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            Console.ReadKey();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Starve();
        }
        override protected void Starve()
        {
            this.stomach -= 3;
        }
    }
}
