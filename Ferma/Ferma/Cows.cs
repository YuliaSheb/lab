using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Cows : Animals,IProduct
    {
        int _value_product = 10;
        public int Value{ get { return _value_product; } }
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
