using System;

namespace Zoo_Lilit_
{
    class Mammal : Animal
    {
        public Mammal(string name, int Age, int Stomach) : base(name, Age, Stomach)
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
