using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Bird:Animal, IGetEggs
    {
        public Bird(string name, DateTime dateOfBirth, int Stomach) : base(name, dateOfBirth, Stomach)
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
