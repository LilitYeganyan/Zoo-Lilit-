using System;
using System.Collections.Generic;
using System.Timers;
using System.Threading;

namespace Zoo_Lilit_
{
    class Fox : Mammal
    {
        private Thread _thread { get; set; }
       // public Timer timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
        
        public Fox(string name, int Age, int Stomach) : base(name, Age, Stomach)
        {
            this.FType = TypeByFood.Predator;
            this.FoodList = new List<FoodType> { FoodType.Meat, FoodType.Milk };
          //  Time();
            this.ACage.Type = AnimalType.Mammal;
            this._thread = new Thread(Starve);
            _thread.Start();
        
        }
        //public void Time()
        //{
        //    timer.AutoReset = true;
        //    timer.Elapsed += Timer_Elapsed;
        //    timer.Start();
        //    Console.ReadKey();
        //}
        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    Starve();
        //}
        override protected void Starve()
        {
           for(int i=0; i<10; i++)
            {
                this.stomach -= 3;
                Thread.Sleep(500);
            }
        }
    }
}
