using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Chikens : Animals
    {
        int _value_product = 9;
        public int Value { get { return _value_product; } }
        public Chikens(int food) : base(food)
        {

        }
        public Chikens()
        {

        }
        public override string ToString()
        {
            return "Eat chikens (in kg) - " + Food;
        }
        public void Feed_chicken()
        {

        }
        public void Egg()
        {

        }
       
    }
}
