using System;

namespace Zoo_Lilit_
{
    class Insect : Animal, IGetEggs
    {
        public Insect(string name, int Age, int Stomach) : base(name, Age, Stomach)
        { }
        public int GetEggs()
        {

            int eggCount = Age + 50;

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
