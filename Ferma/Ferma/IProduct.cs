using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    interface IProduct
    {
       int Cost { get; }
        int Value { get; }
        void Put(int value_product);
    }
}
