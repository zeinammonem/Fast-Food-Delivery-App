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
    public partial class DrinksForm : Form
    {
        public DrinksForm()//DEFAULT CONSTRUCTOR
        {
            InitializeComponent();
        }

        string UserName;

        public DrinksForm(string UserName) //CONSTRUCTOR
        {
            InitializeComponent();
            this.UserName = UserName;
            
        }

        private void DrinksForm_Load(object sender, EventArgs e)
        {

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
            int pepsi = (int)UD_pepsi.Value; //DOWN CASTING FROM DECIMAL TO INT
            int sprite = (int)UD_sprite.Value;
            int fantaOrange = (int)UD_fantaOrange.Value;
            int fantaApple = (int)UD_fantaapple.Value;
            int orangeJuice = (int)UD_orangejuice.Value;
            int appleJuice = (int)UD_applejuice.Value;
            int water = (int)UD_water.Value;
            int mixChocolate = (int)UD_mixchocolate.Value;

            int[] drinksNumber = { pepsi, sprite, fantaOrange, fantaApple, orangeJuice, appleJuice, water, mixChocolate };
            string[] drinksName = { "pepsi", "sprite", "fantaOrange", "fantaApple", "orangeJuice", "appleJuice", "water", "mixChocolate " };

            Drinks drinks = new Drinks(pepsi, sprite, fantaOrange, fantaApple, orangeJuice, appleJuice, water, mixChocolate);
            double total_price = drinks.Calculate_total_price();

            this.Hide();
            Form1 form1 = new Form1(total_price, "Drinks",drinksNumber,drinksName,UserName);
            form1.Show();
        }
    }
}
