using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class Drinks : Food
    {

        private double total_price;
        public double Total_price { get; set; }

        private double pepsi = 15;
        private double sprite = 15;
        private double fantaOrange = 15;
        private double fantaApple = 15;
        private double orangeJuice = 10;
        private double appleJuice = 10;
        private double water = 7;
        private double mixChocolate = 8;

        private int num_pepsi;
        private int num_sprite;
        private int num_fantaOrange;
        private int num_fantaApple;
        private int num_orangeJuice;
        private int num_appleJuice;
        private int num_water;
        private int num_mixChocolate;
        

        

        public Drinks(int num_pepsi, int num_sprite, int num_fantaOrange, int num_fantaApple, int num_orangeJuice, int num_appleJuice, int num_water, int num_mixChocolate)
        {
            this.num_pepsi = num_pepsi;
            this.num_sprite = num_sprite;
            this.num_fantaOrange = num_fantaOrange;
            this.num_fantaApple = num_fantaApple;
            this.num_orangeJuice = num_orangeJuice;
            this.num_appleJuice = num_appleJuice;
            this.num_water = num_water;
            this.num_mixChocolate = num_mixChocolate;
        }

        



        public override double Calculate_total_price()
        {
            total_price = num_pepsi * pepsi + num_sprite * sprite + num_fantaOrange * fantaOrange + num_fantaApple * fantaApple + num_orangeJuice * orangeJuice + num_appleJuice * appleJuice + num_water * water + num_mixChocolate * mixChocolate;
            return total_price;
        }

    }
}
