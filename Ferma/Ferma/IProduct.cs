using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    interface IProduct
    {
         int Value { get; }
        const int cost = 77;
        static int GetCost(int value) => value*cost;
    }
}
