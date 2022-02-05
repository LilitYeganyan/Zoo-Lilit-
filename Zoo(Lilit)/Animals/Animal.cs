using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Animal
    {
        protected string Name { get; set; }
        protected TypeByFood FType { get; set; }
        public List<Food> FoodList { get; set; }
        public int StomachSize { get; set; }
        internal DateTime DateOfBirth;
        internal int stomach;

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        private Timer _timer = new Timer(100);

        public Animal(string name, DateTime DateOfBirth, int stomach)
        {
            this.Name = name;
            this.stomach = stomach;
            this.DateOfBirth = DateOfBirth;
            _timer.Elapsed += _timer_Elapsed;
            this.StomachSize = stomach;
            FoodList = new List<Food>();
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
            for (int i = 0; i < FoodList.Count; i++)
            {
                if (food == FoodList[i])
                {
                    count++;
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
