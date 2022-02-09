using System;
using System.Collections.Generic;
using System.Timers;

namespace Zoo_Lilit_
{
    class Animal
    {
        protected string Name { get; set; }
        internal TypeByFood FType { get; set; }
        public List<FoodType> FoodList { get; set; }
        public Food food { get; set; }
        public int StomachSize { get; set; }
        internal DateTime DateOfBirth;
        internal int stomach;
        internal Cage ACage { get; set; }
        public int Age { get; set; }

        private Timer _timer = new Timer(100);

        public Animal(string name, int Age, int stomach)
        {
            this.Name = name;
            this.stomach = stomach;
            this.Age = DateTime.Now.Year - DateOfBirth.Year;
            //this.DateOfBirth = DateOfBirth;
            _timer.Elapsed += _timer_Elapsed;
            this.StomachSize = stomach;
            FoodList = new List<FoodType>();
        }

        public void FollowEvent()
        {
            this.ACage.TheFoodWereSet += Eat;
        }
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Stomach--;
        }

        private int Stomach
        {
            get
            {
                return this.stomach;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 10)
                {
                    value = 10;
                }
                else
                {
                    value = this.stomach;
                }
            }
        }

        public int StomachSizes { get; private set; }

        virtual protected bool CanEat(Food food)
        {
            int count = 0;
            List<FoodType> list = food.FeedbyType(this, food);
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < FoodList.Count; j++)
                {
                    if (list[i] == FoodList[j])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        virtual internal void Eat(Food food)
        {
            if (CanEat(food))
            {
                this.stomach = this.StomachSizes;
                Console.WriteLine("Կշտացել է");
            }
            if (this.stomach == 0)
            {
                Console.WriteLine("կենդանին սատկեց");
            }

        }
        virtual protected void Starve() { }
        virtual protected void Vois() { }

    }
}
