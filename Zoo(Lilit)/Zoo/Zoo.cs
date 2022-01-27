using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Collections;

namespace Zoo_Lilit_
{
    class Zoo
    {
        internal Employee employee;
        internal List<Cage> AnimalsCage { get; set; }
        public Zoo()
        {
            this.AnimalsCage = new List<Cage>();
        }
        internal void EmployeeAddFoodInContainer(Food food)
        {
            foreach (Cage cage in AnimalsCage)
            {
                employee.AddFoodinfContainer(cage, food);
            }
        }

        internal void FoodWereSet(Food food)//Անկեղծ ասած event-ների պահը լավ չեմ հասկանում
        {
            foreach (Cage cage in AnimalsCage)
            {

            }

        }
    }
}
