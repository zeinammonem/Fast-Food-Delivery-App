using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class Kfc : Food
    {
        private double total_price;
        public double Total_price { get; set; }

        private double chickenBucket12pieces = 250;
        private double chickenBucket16pieces = 200;
        private double chickenBucket20pieces = 350;
        private double twisterSandwich = 30;
        private double twisterSandwichSpicy = 35;
        private double rizo = 30;
        private double rizoSpicy = 35;
        private double friesSmall = 20;
        private double friesMedium = 23;
        private double friesLarge = 25;


        private int num_chickenBucket12pieces;
        private int num_chickenBucket16pieces;
        private int num_chickenBucket20pieces;
        private int num_twisterSandwich;
        private int num_twisterSandwichSpicy;
        private int num_rizo;
        private int num_rizoSpicy;
        private int num_friesSmall;
        private int num_friesMedium;
        private int num_friesLarge;


        public Kfc(int num_chickenBucket12pieces, int num_chickenBucket16pieces, int num_chickenBucket20pieces, int num_twisterSandwich, int num_twisterSandwichSpicy, int num_rizo, int num_rizoSpicy, int num_friesSmall, int num_friesMedium, int num_friesLarge)
        {
            this.num_chickenBucket12pieces = num_chickenBucket12pieces;
            this.num_chickenBucket16pieces = num_chickenBucket16pieces;
            this.num_chickenBucket20pieces = num_chickenBucket20pieces;
            this.num_twisterSandwich = num_twisterSandwich;
            this.num_twisterSandwichSpicy = num_twisterSandwichSpicy;
            this.num_rizo = num_rizo;
            this.num_rizoSpicy = num_rizoSpicy;
            this.num_friesSmall = num_friesSmall;
            this.num_friesMedium = num_friesMedium;
            this.num_friesLarge = num_friesLarge;

        }

        public override double Calculate_total_price()
        {
            total_price = num_chickenBucket12pieces * chickenBucket12pieces + num_chickenBucket16pieces * chickenBucket16pieces + num_chickenBucket20pieces * chickenBucket20pieces + num_twisterSandwich * twisterSandwich + num_twisterSandwichSpicy * twisterSandwichSpicy + num_rizo * rizo + num_rizoSpicy * rizoSpicy + num_friesSmall * friesSmall + num_friesMedium * friesMedium + num_friesLarge * friesLarge;
            return total_price;
        }


    }
}
