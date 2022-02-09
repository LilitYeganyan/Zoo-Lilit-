using System;

namespace Zoo_Lilit_
{
    class Bird : Animal, IGetEggs
    {
        public Bird(string name, int Age, int Stomach) : base(name, Age, Stomach)
        { }
        public int GetEggs()
        {
            int eggCount = Age + 5;

            if (Age < 5)
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
