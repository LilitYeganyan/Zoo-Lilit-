using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;


namespace Zoo_Lilit_
{
    class Bee : Insect
    {
        public Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        public Bee(string name, int DateOfBirth, int Stomach) : base(name, DateOfBirth, Stomach)
        {
            this.FType = TypeByFood.Predator;
            this.FoodList = new List<Food> { Food.Meat, Food.Worm };
            Time();
            this.cage.Type = AnimalType.Insect;
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
