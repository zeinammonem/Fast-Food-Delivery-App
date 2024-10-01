using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class Hardees : Food
    {


        public double Total_price { get; set; }

        public Hardees() { } // default constructor


        private double chickenFillet = 50;
        private double superStarBeef = 50;
        private double starNuggets1pieces = 10;
        private double curlyFriesSmall = 24;
        private double curlyFriesMedium = 27;
        private double curlyFriesLarge = 30;


        public int num_chickenFillet;
        public int num_superStarBeef;
        public int num_starNuggets1pieces;
        public int num_curlyFriesSmall;
        public int num_curlyFriesMedium;
        public int num_curlyFriesLarge;

        


        public Hardees(int num_chickenFillet, int num_superStarBeef, int num_starNuggets1pieces, int num_curlyFriesSmall, int num_curlyFriesMedium, int num_curlyFriesLarge)
        {
            this.num_chickenFillet = num_chickenFillet;
            this.num_superStarBeef = num_superStarBeef;
            this.num_starNuggets1pieces = num_starNuggets1pieces;
            this.num_curlyFriesSmall = num_curlyFriesSmall;
            this.num_curlyFriesMedium = num_curlyFriesMedium;
            this.num_curlyFriesLarge = num_curlyFriesLarge;

        }

        public override double Calculate_total_price()
        {
            Total_price = num_chickenFillet * chickenFillet + num_superStarBeef * superStarBeef + num_starNuggets1pieces * starNuggets1pieces + num_curlyFriesSmall * curlyFriesSmall + num_curlyFriesMedium * curlyFriesMedium + num_curlyFriesLarge * curlyFriesLarge;
            return Total_price;
        }

       

        

    }
}
