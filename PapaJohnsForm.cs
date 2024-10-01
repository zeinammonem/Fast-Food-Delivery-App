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
    public partial class PapaJohnsForm : Form
    {
        public PapaJohnsForm()
        {
            InitializeComponent();
        }

        string UserName;

        public PapaJohnsForm(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void btn_pizza_Click(object sender, EventArgs e)
        {
            panelOver.Hide();
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
            int pizzaPepperoniSmall = (int)UD_pepperonismall.Value;
            int pizzaPepperoniMedium = (int)UD_pepperonimedium.Value;
            int pizzaPepperoniLarge = (int)UD_pepperonilarge.Value;
            int pizzaRanchSmall = (int)UD_ranchsmall.Value;
            int pizzaRanchMedium = (int)UD_ranchmedium.Value;
            int pizzaRanchLarge = (int)UD_ranchlarge.Value;
            int pizzaBbqSmall = (int)UD_bbqsmall.Value;
            int pizzaBbqMedium = (int)UD_bbqmedium.Value;
            int pizzaBbqLarge = (int)UD_bbqlarge.Value;

            PapaJohns papajohns = new PapaJohns(pizzaPepperoniSmall, pizzaRanchMedium, pizzaRanchLarge, pizzaPepperoniSmall, pizzaPepperoniMedium, pizzaPepperoniLarge, pizzaBbqSmall, pizzaBbqMedium, pizzaBbqLarge);
            double total_price = papajohns.Calculate_total_price();

            int[] papajohnNumber = { pizzaPepperoniSmall, pizzaRanchMedium, pizzaRanchLarge, pizzaPepperoniLarge, pizzaPepperoniMedium, pizzaPepperoniLarge, pizzaBbqSmall, pizzaBbqMedium, pizzaBbqLarge };
            string[] papajohnsName = { "pizzaPepperoniSmall", "pizzaRanchMedium", "pizzaRanchLarge", "pizzaPepperoniSmall", "pizzaPepperoniMedium", "pizzaPepperoniLarge", "pizzaBbqSmall", "pizzaBbqMedium", "pizzaBbqLarge" };  

            this.Hide();
            Form1 form1 = new Form1(total_price, "Papa Johns",papajohnNumber,papajohnsName,UserName);
            form1.Show();
        }
    }
}
