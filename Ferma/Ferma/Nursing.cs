using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Nursing:People
    {
        public Nursing(int food) : base(food)
        {

        }
        public override string ToString()
        {
            return "Eat people (in kg) - " + Food;
        }
    }
}
