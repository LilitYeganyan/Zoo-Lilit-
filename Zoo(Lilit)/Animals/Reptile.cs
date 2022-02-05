using System;

namespace Zoo_Lilit_
{
    class Reptile : Animal, IGetEggs
    {
        public Reptile(string name, int age, int Stomach) : base(name, age, Stomach)
        { }
        public int GetEggs()
        {
            //code duplication
            //int age = 2022 - this.DateOfBirth;
            int eggCount = Age + 10;

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
