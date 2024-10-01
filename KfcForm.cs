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
    public partial class KfcForm : Form
    {
        public KfcForm()
        {
            InitializeComponent();
        }

        string UserName;

        public KfcForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {

            panelOver.Hide();
            //sandwich options are only visible

            pb_twister.Visible = true;
            lbl_twisternormal.Visible = true;
            lbl_twisterspicy.Visible = true;
            UD_twisternormal.Visible = true;
            UD_twisterspicy.Visible = true;

            pb_rizo.Visible = true;
            lbl_rizoBBQ.Visible = true;
            lbl_rizoSpicy.Visible = true;
            UD_rizobbq.Visible = true;
            UD_rizospicy.Visible = true;


            //////////////////////////////////
            ///
            pb_chickenbucket.Visible = false;
            lbl_chickenbucket12.Visible = false;
            lbl_chickenbucket16.Visible = false;
            lbl_chickenbucket20.Visible = false;
            UD_chickenB12.Visible = false;
            UD_chickenB16.Visible = false;
            UD_chickenB20.Visible = false;

            pb_fries.Visible = false;
            lbl_frieslarge.Visible = false;
            lbl_friesmedium.Visible = false;
            lbl_friessmall.Visible = false;
            UD_friesLarge.Visible = false;
            UD_friesMedium.Visible = false;
            UD_friesSmall.Visible = false;

        }

        private void btn_fries_Click(object sender, EventArgs e)
        {
            panelOver.Hide();
            //only chicken buckets and fries are visible

            pb_chickenbucket.Visible = true;
            lbl_chickenbucket12.Visible = true;
            lbl_chickenbucket16.Visible = true;
            lbl_chickenbucket20.Visible = true;
            UD_chickenB12.Visible = true;
            UD_chickenB16.Visible = true;
            UD_chickenB20.Visible = true;

            pb_fries.Visible = true;
            lbl_frieslarge.Visible = true;
            lbl_friesmedium.Visible = true;
            lbl_friessmall.Visible = true;
            UD_friesLarge.Visible = true;
            UD_friesMedium.Visible = true;
            UD_friesSmall.Visible = true;

            ////////////////////////////////
            ///

            pb_twister.Visible = false;
            lbl_twisternormal.Visible = false;
            lbl_twisterspicy.Visible = false;
            UD_twisternormal.Visible = false;
            UD_twisterspicy.Visible = false;

            pb_rizo.Visible = false;
            lbl_rizoBBQ.Visible = false;
            lbl_rizoSpicy.Visible = false;
            UD_rizobbq.Visible = false;
            UD_rizospicy.Visible = false;



        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting this page will remove any orders you initially ordered");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_checkoutt_Click(object sender, EventArgs e)
        {
            int chickenbucket12 = (int)UD_chickenB12.Value;
            int chickenbucket16 = (int)UD_chickenB16.Value;
            int chickenucket20 = (int)UD_chickenB20.Value;
            int twisternormal = (int)UD_twisternormal.Value;
            int twisterspicy = (int)UD_twisterspicy.Value;
            int rizobbq = (int)UD_rizobbq.Value;
            int rizospicy = (int)UD_rizospicy.Value;
            int friessmall = (int)UD_friesSmall.Value;
            int friesmedium = (int)UD_friesMedium.Value;
            int frieslarge = (int)UD_friesLarge.Value;


            Kfc kfc = new Kfc(chickenbucket12, chickenbucket16, chickenucket20, twisternormal, twisterspicy, rizobbq, rizospicy, friessmall, friesmedium, frieslarge);
            double total_price = kfc.Calculate_total_price();

            int[] kfcNumber = { chickenbucket12, chickenbucket16, chickenucket20, twisternormal, twisterspicy, rizobbq, rizospicy, friessmall, friesmedium, frieslarge };
            string[] kfcName = { "chickenbucket12", "chickenbucket16", "chickenucket20", "twisternormal", "twisterspicy", "rizobbq", "rizospicy", "friessmall", "friesmedium", "frieslarge" };


            this.Hide();
            Form1 form1 = new Form1(total_price, "KFC",kfcNumber,kfcName,UserName);
            form1.Show();
        }
    }
}
