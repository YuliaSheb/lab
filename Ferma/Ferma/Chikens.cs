using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Chikens : Animals
    {
        public Chikens(int food,string opred) : base(food,opred)
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
