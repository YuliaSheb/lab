using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Dogs:Animals
    {
        public Dogs(int food,string opred) : base(food,opred)
        {

        }
        public Dogs()
        {

        }
        public override string ToString()
        {
            return "Eat dogs (in kg) - " + Food;
        }
        public void Feed_dog()
        {

        }
    }
}
