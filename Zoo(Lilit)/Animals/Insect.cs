using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Insect:Animal, IGetEggs
    {
        public Insect(string name, DateTime DateOfBirth, int Stomach) : base(name, DateOfBirth, Stomach)
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
