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
    public partial class McdonaldsForm : Form
    {
        public McdonaldsForm()
        {
            InitializeComponent();
        }

        string UserName;
        public McdonaldsForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {

            panelOver.Hide();
            //only sandwich options are visible

            pb_mcfries.Visible = false;

            lbl_mcfrieslarge.Visible = false;
            lbl_mcfriesmedium.Visible = false;
            lbl_mcfriessmall.Visible = false;

            UD_mcfriesLarge.Visible = false;
            UD_mcfriesMedium.Visible = false;
            UD_mcfriesSmall.Visible = false;

            /////////////////////////////////////////////
            ///

            lbl_bigmacbeef.Visible = true;
            lbl_bigmacbeefspicy.Visible = true;
            lbl_bigmacchicken.Visible = true;
            lbl_bigmacchickenspicy.Visible = true;
            lbl_combo.Visible = true;

            pb_bigmacbeef.Visible = true;
            pb_bigmacchicken.Visible = true;
            pb_combo.Visible = true;

            UD_bigmacbeef.Visible = true;
            UD_bigmacbeefspicy.Visible = true;
            UD_bigmacchicken.Visible = true;
            UD_bigmacchickenspicy.Visible = true;
            UD_bigmaccombo.Visible = true;

            /////////////////////////////////////////////
            ///

            pb_sundaecaramel.Visible = false;
            pb_sundaechocolate.Visible = false;
            pb_sundaestrawberry.Visible = false;

            lbl_sundaecaramel.Visible = false;
            lbl_sundaechocolate.Visible = false;
            lbl_sundaestrawberry.Visible = false;

            UD_sundaeCaramel.Visible = false;
            UD_sundaeChocolate.Visible = false;
            UD_sundaeStrawberry.Visible = false;

        }

        private void btn_fries_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            //only fries options will be visible




            pb_mcfries.Visible = true;

            lbl_mcfrieslarge.Visible = true;
            lbl_mcfriesmedium.Visible = true;
            lbl_mcfriessmall.Visible = true;

            UD_mcfriesLarge.Visible = true;
            UD_mcfriesMedium.Visible = true;
            UD_mcfriesSmall.Visible = true;


            /////////////////////////////////////////
            ///

            lbl_bigmacbeef.Visible = false;
            lbl_bigmacbeefspicy.Visible = false;
            lbl_bigmacchicken.Visible = false;
            lbl_bigmacchickenspicy.Visible = false;
            lbl_combo.Visible = false;

            pb_bigmacbeef.Visible = false;
            pb_bigmacchicken.Visible = false;
            pb_combo.Visible = false;

            UD_bigmacbeef.Visible = false;
            UD_bigmacbeefspicy.Visible = false;
            UD_bigmacchicken.Visible = false;
            UD_bigmacchickenspicy.Visible = false;
            UD_bigmaccombo.Visible = false;

            //////////////////////////////////////////
            ///


            pb_sundaecaramel.Visible = false;
            pb_sundaechocolate.Visible = false;
            pb_sundaestrawberry.Visible = false;

            lbl_sundaecaramel.Visible = false;
            lbl_sundaechocolate.Visible = false;
            lbl_sundaestrawberry.Visible = false;

            UD_sundaeCaramel.Visible = false;
            UD_sundaeChocolate.Visible = false;
            UD_sundaeStrawberry.Visible = false;
        }

        private void btn_sundae_Click(object sender, EventArgs e)
        {
            panelOver.Hide();
            //only sundae options are visible

            lbl_bigmacbeef.Visible = false;
            lbl_bigmacbeefspicy.Visible = false;
            lbl_bigmacchicken.Visible = false;
            lbl_bigmacchickenspicy.Visible = false;
            lbl_combo.Visible = false;

            pb_bigmacbeef.Visible = false;
            pb_bigmacchicken.Visible = false;
            pb_combo.Visible = false;

            UD_bigmacbeef.Visible = false;
            UD_bigmacbeefspicy.Visible = false;
            UD_bigmacchicken.Visible = false;
            UD_bigmacchickenspicy.Visible = false;
            UD_bigmaccombo.Visible = false;

            ///////////////////////////////////////
            ///

            pb_mcfries.Visible = false;

            lbl_mcfrieslarge.Visible = false;
            lbl_mcfriesmedium.Visible = false;
            lbl_mcfriessmall.Visible = false;

            UD_mcfriesLarge.Visible = false;
            UD_mcfriesMedium.Visible = false;
            UD_mcfriesSmall.Visible = false;

            ////////////////////////////////////////////
            ///

            pb_sundaecaramel.Visible = true;
            pb_sundaechocolate.Visible = true;
            pb_sundaestrawberry.Visible = true;

            lbl_sundaecaramel.Visible = true;
            lbl_sundaechocolate.Visible = true;
            lbl_sundaestrawberry.Visible = true;

            UD_sundaeCaramel.Visible = true;
            UD_sundaeChocolate.Visible = true;
            UD_sundaeStrawberry.Visible = true;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting this page will remove any orders you initially ordered");
            Form1 form1 = new Form1(UserName);
            form1.Show();
            this.Hide();
        }

        private void btn_checkoutt_Click(object sender, EventArgs e)
        {

            int bigmacbeef = (int)UD_bigmacbeef.Value;
            int bigmacbeefspicy = (int)UD_bigmacbeefspicy.Value;
            int bigmacchicken = (int)UD_bigmacchicken.Value;
            int bigmacchickenspicy = (int)UD_bigmacchickenspicy.Value;
            int bigmaccombo = (int)UD_bigmaccombo.Value;
            int mcfriessmall = (int)UD_mcfriesLarge.Value;
            int mcfriesmedium = (int)UD_mcfriesMedium.Value;
            int mcfireslarge = (int)UD_mcfriesLarge.Value;
            int sundaeecaramel = (int)UD_sundaeCaramel.Value;
            int sundaechocolate = (int)UD_sundaeChocolate.Value;
            int sundaestrawberry = (int)UD_sundaeStrawberry.Value;

            Mcdonalds mcdonalds = new Mcdonalds(bigmacbeef, bigmacbeefspicy, bigmacchicken, bigmacchickenspicy, bigmaccombo, mcfriessmall, mcfriesmedium, mcfireslarge, sundaeecaramel, sundaechocolate, sundaestrawberry);
            double total_price = mcdonalds.Calculate_total_price();

            int[] mcdonldsNumber = { bigmacbeef, bigmacbeefspicy, bigmacchicken, bigmacchickenspicy, bigmaccombo, mcfriessmall, mcfriesmedium, mcfireslarge, sundaeecaramel, sundaechocolate, sundaestrawberry };
            string[] mcdonaldsNmae = { "bigmacbeef", "bigmacbeefspicy", "bigmacchicken", "bigmacchickenspicy", "bigmaccombo", "mcfriessmall", "mcfriesmedium", "mcfireslarge", "sundaeecaramel", "sundaechocolate", "sundaestrawberry" };


            this.Hide();
            Form1 form1 = new Form1(total_price, "Mcdonalds",mcdonldsNumber,mcdonaldsNmae,UserName);
            form1.Show();
        }
    }
}
