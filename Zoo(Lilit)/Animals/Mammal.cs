using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Mammal : Animal
    {
        public Mammal(string name, DateTime DateOfBirth, int Stomach) : base(name, DateOfBirth, Stomach)
        { }
        protected int GetMilke()
        {
            if (Age <= 5)
            {
                Console.WriteLine("Չի կարող կաթ տալ");
                return 0;
            }
            else
            {
                int milk = Age + 10;
                return milk;
            }
        }
    }
}
