using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Shepherd:People
    {
        public Shepherd(int food,string opred) : base(food,opred)
        {

        }
        public Shepherd()
        {

        }
        public override string ToString()
        {
            return "Eat people (in kg) - " + Food;
        }
    }
}
