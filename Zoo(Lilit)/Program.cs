using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Lilit_
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = Food.Milk;
            Cage cage = new Cage();
            cage.AddFoodinContainer(food);
        }
    }
}
