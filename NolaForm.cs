using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodAppFinal
{
    public partial class NolaForm : Form
    {
        public NolaForm()
        {
            InitializeComponent();
        }

        string UserName;
        public NolaForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;

        }

        private void btn_cake_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            lbl_chocolatecake.Visible = true;
            lbl_redvelvet.Visible = true;
            pb_chocolatecake.Visible = true;
            pb_redvelvetcake.Visible = true;
            UD_chocolateCake.Visible = true;
            UD_redVelvetCake.Visible = true;

            lbl_lotuscupcake.Visible = false;
            lbl_redvelvetcupcake.Visible = false;
            lbl_chocolatecupcake.Visible = false;
            pb_chocolatecupcake.Visible = false;
            pb_lotuscupcake.Visible = false;
            pb_redvelvetcupcake.Visible = false;
            UD_ChocolateCupcake.Visible = false;
            UD_LotusCupcake.Visible = false;
            UD_RedVelvetCupcake.Visible = false;
        }

        private void btn_fries_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            lbl_chocolatecake.Visible = false;
            lbl_redvelvet.Visible = false;
            pb_chocolatecake.Visible = false;
            pb_redvelvetcake.Visible = false;
            UD_chocolateCake.Visible = false;
            UD_redVelvetCake.Visible = false;

            lbl_lotuscupcake.Visible = true;
            lbl_redvelvetcupcake.Visible = true;
            lbl_chocolatecupcake.Visible = true;
            pb_chocolatecupcake.Visible = true;
            pb_lotuscupcake.Visible = true;
            pb_redvelvetcupcake.Visible = true;
            UD_ChocolateCupcake.Visible = true;
            UD_LotusCupcake.Visible = true;
            UD_RedVelvetCupcake.Visible = true;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting this page will remove any orders you initially ordered");
            Form1 form1 = new Form1(UserName);
            form1.Show();
            this.Hide();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            int chocolateCake = (int)UD_chocolateCake.Value;
            int redVelvetCake = (int)UD_RedVelvetCupcake.Value;
            int chocolateCupCake = (int)UD_ChocolateCupcake.Value;
            int redVelvetCupCake = (int)UD_RedVelvetCupcake.Value;
            int lotusCupCake = (int)UD_LotusCupcake.Value;

            Nola nola = new Nola(chocolateCake, redVelvetCake, chocolateCupCake, redVelvetCupCake, lotusCupCake);
            double total_price = nola.Calculate_total_price();

            int[] nolaNumber = { chocolateCake, redVelvetCake, chocolateCupCake, redVelvetCupCake, lotusCupCake };
            string[] nolaName = { "chocolateCake", "redVelvetCake", "chocolateCupCake", "redVelvetCupCake", "lotusCupCake" };

            this.Hide();
            Form1 form1 = new Form1(total_price, "Nola",nolaNumber,nolaName,UserName);
            form1.Show();
        }
    }
}
