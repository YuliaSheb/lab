using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Farm_tenant
    {
        protected int Food { get; set; }  
        public Farm_tenant(int food)
        {
            Food = food;
        }
        public Farm_tenant()
        {
            
        }
    }
}
