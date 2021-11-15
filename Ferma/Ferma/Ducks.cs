using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Ducks : Animals
    {
        public Ducks(int food) : base(food)
        {

        }
        public override string ToString()
        {
            return "Eat ducks (in kg) - " + Food;
        }
        public void Feed_ducks()
        {

        }
        public void Eggs()
        {

        }
    }
}
