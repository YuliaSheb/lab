using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Horses:Animals
    {
        public int Endurance { get; set; }
        public Horses(int food, int endurance) : base(food)
        {
            Endurance = endurance;
        }
        public override string ToString()
        {
            return "Eat horses (in kg) - " + Food;
        }
        public void Eat_horses()
        {

        }
        public void Feed_horses()
        {

        }
        public void Carry()
        {

        }
    }
}
