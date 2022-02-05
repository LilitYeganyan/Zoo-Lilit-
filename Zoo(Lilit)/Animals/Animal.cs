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
        public Cage cage { get; set; }
        public int StomachSize { get; set; }
        internal DateTime DateOfBirth;
        internal int stomach;

        public int StomachSizes { get; private set; }


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

        public void FolloweEvent(Cage cage)
        {
            this.cage = cage;
            this.cage.TheFoodWereSet += See;
            this.cage.TheFoodWereSet += Move;
            this.cage.TheFoodWereSet += Vois;
            this.cage.TheFoodWereSet += EatEvent;
        }

        virtual protected void Starve() { }
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

        public void EatEvent()
        {
            Food food = cage.AnimalContainer.food;
            Eat(food);
        }

        virtual protected void Vois()
        {
            Console.WriteLine("կերավ!");
        }

        virtual protected void Move()
        {
            Console.WriteLine("մոտեցավ կերին");
        }

        virtual protected void See()
        {
            Console.WriteLine("Տեսավ կերը");
        }
    }
}
