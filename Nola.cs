using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodAppFinal
{
    internal class Nola : Food
    {

        private double total_price;
        public double Total_price { get; set; }

        private double chocolalteCake = 200;
        private double redVelvetCake = 200;
        private double chocolateCupcake = 30;
        private double redVelvetCupcake = 30;
        private double lotusCupcake = 30;

        private int num_chocolalteCake;
        private int num_redVelvetCake;
        private int num_chocolateCupcake;
        private int num_redVelvetCupcake;
        private int num_lotusCupcake;

        public Nola(int num_chocolalteCake, int num_redVelvetCake, int num_chocolateCupcake, int num_redVelvetCupcake, int num_lotusCupcake)
        {
            this.num_chocolalteCake = num_chocolalteCake;
            this.num_redVelvetCake = num_redVelvetCake;
            this.num_chocolateCupcake = num_chocolateCupcake;
            this.num_redVelvetCupcake = num_redVelvetCupcake;
            this.num_lotusCupcake = num_lotusCupcake;
        }

        public override double Calculate_total_price()
        {
            total_price = num_chocolalteCake * chocolalteCake +num_redVelvetCake * redVelvetCake + num_chocolateCupcake * chocolateCupcake + num_redVelvetCupcake * redVelvetCupcake + num_lotusCupcake * lotusCupcake;
            return total_price;
        }

    }
}
