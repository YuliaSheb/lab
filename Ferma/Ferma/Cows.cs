using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Cows : Animals
    {
        public Cows(int food) : base(food)
        {

        }
        public Cows()
        {

        }
        public override string ToString()
        {
            return "Eat cows (in kg) - " + Food;
        }
        public void Feed_cows()
        {

        }
        public void Milk()
        {

        }
    }
}
