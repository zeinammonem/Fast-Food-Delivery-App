using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class PapaJohns : Food
    {

        private double total_price;
        public double Total_price { get; set; }

        private double pizzaPepperoniSmall = 60;
        private double pizzaPepperoniMedium = 90;
        private double pizzaPepperoniLarge = 120;
        private double pizzaBbqSmall = 60;
        private double pizzaBbqMedium = 90;
        private double pizzaBbqLarge = 120;
        private double pizzaRanchSmall = 60;
        private double pizzaRanchMedium = 90;
        private double pizzaRanchLarge = 120;

        private int num_pizzaPepperoniSmall;
        private int num_pizzaPepperoniMedium;
        private int num_pizzaPepperoniLarge;
        private int num_pizzaBbqSmall;
        private int num_pizzaBbqMedium;
        private int num_pizzaBbqLarge;
        private int num_pizzaRanchSmall;
        private int num_pizzaRanchMedium;
        private int num_pizzaRanchLarge;

        public PapaJohns(int num_pizzaPepperoniSmall, int num_pizzaPepperoniMedium, int num_pizzaPepperoniLarge, int num_pizzaBbqSmall, int num_pizzaBbqMedium, int num_pizzaBbqLarge, int num_pizzaRanchSmall, int num_pizzaRanchMedium, int num_pizzaRanchLarge)
        {
            this.num_pizzaPepperoniSmall = num_pizzaPepperoniSmall;
            this.num_pizzaPepperoniMedium = num_pizzaPepperoniMedium;
            this.num_pizzaPepperoniLarge = num_pizzaPepperoniLarge;
            this.num_pizzaBbqSmall = num_pizzaBbqSmall;
            this.num_pizzaBbqMedium = num_pizzaBbqMedium;
            this.num_pizzaBbqLarge = num_pizzaBbqLarge;
            this.num_pizzaRanchSmall = num_pizzaRanchSmall;
            this.num_pizzaRanchMedium = num_pizzaRanchMedium;
            this.num_pizzaRanchLarge = num_pizzaRanchLarge;
        }

        public override double Calculate_total_price()
        {
            total_price = num_pizzaPepperoniSmall * pizzaPepperoniSmall + num_pizzaPepperoniMedium * pizzaPepperoniMedium + num_pizzaPepperoniLarge * pizzaPepperoniLarge + num_pizzaBbqSmall * pizzaBbqSmall + num_pizzaBbqMedium * pizzaBbqMedium + num_pizzaBbqLarge * pizzaBbqLarge + num_pizzaRanchSmall * pizzaRanchSmall + num_pizzaRanchMedium * pizzaRanchMedium + num_pizzaRanchLarge * pizzaRanchLarge;
            return total_price;
        }


    }
}
