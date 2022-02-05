using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Eagle : Bird
    {
        public Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        public Eagle(string name, int DateOfBirth, int Stomach) : base(name, DateOfBirth, Stomach)
        {
            this.FType = TypeByFood.Predator;
            this.FoodList = new List<Food> { Food.Meat, Food.Worm };
            Time();
            this.cage.Type = AnimalType.Bird;
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
            this.stomach -= 4;
        }
    }
}
