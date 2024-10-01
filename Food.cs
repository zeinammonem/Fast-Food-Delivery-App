using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal abstract class Food
    {

        public double delivery = 15;


        public abstract double Calculate_total_price();

    }
}
