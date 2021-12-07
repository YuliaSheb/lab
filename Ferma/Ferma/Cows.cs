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
        int _cost = 4;
        public int Cost { get { return _cost; } }
        public int Value { get { return _value_product; } }
        public void Put(int value) { _value_product = value * _value_product * _cost*31; }
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
