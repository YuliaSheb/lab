﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Cows : Animals
    {
        public Cows(int food,string opred) : base(food,opred)
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
