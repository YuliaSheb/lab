using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Horses:Animals
    {
        protected int Endurance { get; set; }
        public Horses(int food, int endurance, string opred):base(food,opred) 
        {
            Endurance = endurance;
        }
        public override string ToString()
        {
            return "Eat horses (in kg) - " + Food;

        }
        public Horses(int food, string opred) : base(food,opred)
        {
           
        }
        public Horses()
        {
            
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
