using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Bird:Animal, IGetEggs
    {
        public Bird(string name, int age, int Stomach) : base(name, age, Stomach)
        { }
        public int GetEggs()
        {
            int age = 2022 - this.DateOfBirth;
            int eggCount = age + 5;

            if (age < 5)
            {
                Console.WriteLine("չի կարող ձու ածել");
                return 0;
            }
            else
            {
                return eggCount;
            }
        }
    }
}
