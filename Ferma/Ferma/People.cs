using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class People:Farm_tenant
    {
        public People(int food) : base(food)
        {

        }
        public People()
        {

        }
        public override string ToString()
        {
            return "Eat people (in kg) - " + Food;
        }
    }
}
