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
    public partial class HardeesForm : Form
    {
        public HardeesForm()
        {
            InitializeComponent();
        }

        string UserName;

        public HardeesForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            //sandwich options are only visible

            lbl_curlyfrieslarge.Visible = false;
            lbl_curlyfriesmedium.Visible = false;
            lbl_curlyfriessmall.Visible = false;

            pb_curlyfries.Visible = false;

            UD_curlyfriesLarge.Visible = false;
            UD_curlyfriesMedium.Visible = false;
            UD_curlyfriesSmall.Visible = false;

            /////////////////////////////////

            pb_chickenfillet.Visible = true;
            pb_starnuggets.Visible = true;
            pb_superstarbeef.Visible = true;

            lbl_chickenfillet.Visible = true;
            lbl_starnuggets.Visible = true;
            lbl_superstarbeef.Visible = true;

            UD_chickenfillet.Visible = true;
            UD_starnuggets.Visible = true;
            UD_superstarbeef.Visible = true;
        }

        private void btn_fries_Click(object sender, EventArgs e)
        {
            panelOver.Hide();
            //only fries options will be visible

            lbl_curlyfrieslarge.Visible = true;
            lbl_curlyfriesmedium.Visible = true;
            lbl_curlyfriessmall.Visible = true;

            pb_curlyfries.Visible = true;

            UD_curlyfriesLarge.Visible = true;
            UD_curlyfriesMedium.Visible = true;
            UD_curlyfriesSmall.Visible = true;

            ////////////////////////////////////////

            pb_chickenfillet.Visible = false;
            pb_starnuggets.Visible = false;
            pb_superstarbeef.Visible = false;

            lbl_chickenfillet.Visible = false;
            lbl_starnuggets.Visible = false;
            lbl_superstarbeef.Visible = false;

            UD_chickenfillet.Visible = false;
            UD_starnuggets.Visible = false;
            UD_superstarbeef.Visible = false;
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
            //only checkout options will be visible

            pb_chickenfillet.Visible = false;
            pb_starnuggets.Visible = false;
            pb_superstarbeef.Visible = false;

            lbl_chickenfillet.Visible = false;
            lbl_starnuggets.Visible = false;
            lbl_superstarbeef.Visible = false;

            UD_chickenfillet.Visible = false;
            UD_starnuggets.Visible = false;
            UD_superstarbeef.Visible = false;

            /////////////////////////////////

            lbl_curlyfrieslarge.Visible = false;
            lbl_curlyfriesmedium.Visible = false;
            lbl_curlyfriessmall.Visible = false;

            pb_curlyfries.Visible = false;

            UD_curlyfriesLarge.Visible = false;
            UD_curlyfriesMedium.Visible = false;
            UD_curlyfriesSmall.Visible = false;

            /////////////////////////////////

            int chickenFillet = (int)UD_chickenfillet.Value;
            int superstarbeef = (int)UD_superstarbeef.Value;
            int starnuggets = (int)UD_starnuggets.Value;
            int curlyfriesmedium = (int)UD_curlyfriesMedium.Value;
            int curlyfriessmall = (int)UD_curlyfriesSmall.Value;
            int curlyfrieslarge = (int)UD_curlyfriesLarge.Value;

            Hardees hardees = new Hardees(chickenFillet, superstarbeef, starnuggets, curlyfriessmall, curlyfriesmedium, curlyfrieslarge);
            double total_price = hardees.Calculate_total_price();

            int[] hardeesNumber = { chickenFillet, superstarbeef, starnuggets, curlyfriessmall, curlyfriesmedium, curlyfrieslarge };
            string[] hardeesName = { "chickenFillet", "superstarbeef", "starnuggets", "curlyfriessmall", "curlyfriesmedium", "curlyfrieslarge" };
            

            this.Hide();
            Form1 form1 = new Form1(total_price, "Hardees",hardeesNumber,hardeesName,UserName);
            form1.Show();
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
