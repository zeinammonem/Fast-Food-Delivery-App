using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class Mcdonalds : Food
    {

        private double total_price;
        public double Total_price
        {
            get { return total_price; }
            set { total_price = value; }
        }


        //prices of items

        private double bigMacBeef = 40;
        private double bigMacBeefSpicy = 45;
        private double bigMacChicken = 40;
        private double bigMacChickenSpicy = 45;
        private double Combo = 30; //when they choose combo we will add extra 30
        private double mcFriesSmall = 20;
        private double mcFriesMedium = 23;
        private double mcFriesLarge = 25;
        private double sundaeCaramel = 25;
        private double sundaeChocolate = 25;
        private double sundaeStrawberry = 25;

        //number of items
        private int num_bigMacBeef;
        private int num_bigMacBeefSpicy;
        private int num_bigMacChicken;
        private int num_bigMacChickenSpicy;
        private int num_Combo;
        private int num_mcFriesSmall;
        private int num_mcFriesMedium;
        private int num_mcFriesLarge;
        private int num_sundaeCaramel;
        private int num_sundaeChocolate;
        private int num_sundaeStrawberry;



        public Mcdonalds(int num_bigMacBeef, int num_bigMacBeefSpicy, int num_bigMacChicken, int num_bigMacChickenSpicy, int num_Combo, int num_mcFriesSmall, int num_mcFriesMedium, int num_mcFriesLarge, int num_sundaeCaramel, int num_sundaeChocolate, int num_sundaeStrawberry)
        {
            this.num_bigMacBeef = num_bigMacBeef;
            this.num_bigMacBeefSpicy = num_bigMacBeefSpicy;
            this.num_bigMacChicken = num_bigMacChicken;
            this.num_bigMacChickenSpicy = num_bigMacChickenSpicy;
            this.num_Combo = num_Combo;
            this.num_mcFriesLarge = num_mcFriesLarge;
            this.num_mcFriesMedium = num_mcFriesMedium;
            this.num_mcFriesSmall = num_mcFriesSmall;
            this.num_sundaeCaramel = num_sundaeCaramel;
            this.num_sundaeChocolate = num_sundaeChocolate;
            this.num_sundaeStrawberry = num_sundaeStrawberry;



        }





        public override double Calculate_total_price()
        {
            total_price = num_bigMacBeef * bigMacBeef + num_bigMacBeefSpicy * bigMacBeefSpicy + num_bigMacChicken * bigMacChicken + num_bigMacChickenSpicy * bigMacChickenSpicy + num_Combo * Combo + num_mcFriesSmall * mcFriesSmall + num_mcFriesMedium * mcFriesMedium + num_mcFriesLarge * mcFriesLarge + num_sundaeCaramel * sundaeCaramel + num_sundaeChocolate * sundaeChocolate + num_sundaeStrawberry * sundaeStrawberry;

            return total_price;
        }

    }
}
