using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Farm_tenant
    {
        public int Food { get; set; }
        public string Opred { get; set; }
        public Farm_tenant(int food,string opred)
        {
            Food = food;
            Opred = opred;
        }
        public Farm_tenant()
        {
            
        }
    }
}
