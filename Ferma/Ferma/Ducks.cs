using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Ducks : Animals,IProduct
    {
        int _value_product = 7 ;
        public int Value { get { return _value_product; } }
        public Ducks(int food) : base(food)
        {

        }
        public Ducks()
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
