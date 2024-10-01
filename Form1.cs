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
    public partial class Form1 : Form
    {
        public Form1() //default con
        {
            InitializeComponent();
        }

        public Form1(string UserName) // database from welcome page
        {
            this.UserName = UserName;
            InitializeComponent();

        }

        //delivery stuff

        private double total_price;
        private string myOrderFrom;
        
        private string UserName;
        private int [] NumberofItems= new int[100];
        private string[] ListofItems = new string[1000];



        

        public Form1(double total_price, string myOrderFrom,int [] NumberofItems, string [] ListofItems, string UserName) //final constructor with database
        {
            InitializeComponent();
            this.total_price = total_price;
            this.myOrderFrom = myOrderFrom;
            this.NumberofItems = NumberofItems;
            this.ListofItems = ListofItems;
            this.UserName = UserName;

        }


    

        private void btn_drinks_Click(object sender, EventArgs e)
        {
            DrinksForm drinks = new DrinksForm();
            this.Hide();
            drinks.Show();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            //food details are only visible
            lbl_delivery.Visible = false;
            lbl_Deliveryy.Visible = false;
            lbl_myorderFrom.Visible = false;
            lbl_RestaurantName.Visible = false;
            lbl_tax.Visible = false;
            lbl_totalprice.Visible = false;
            lbl_tp.Visible = false;
            listBox_Delivery.Visible = false;
            lbl_Deliveryplace.Visible = false;
            comboBox_deliveryplace.Visible = false;



            btn_hardees.Visible = true;
            btn_kfc.Visible = true;
            btn_mcdonalds.Visible = true;
            btn_nola.Visible = true;
            btn_papajohns.Visible = true;

            lbl_hardees.Visible = true;
            lbl_kfc.Visible = true;
            lbl_mcdonalds.Visible = true;
            lbl_nola.Visible = true;
            lbl_papaJohns.Visible = true;

        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            panelOver.Hide();

            // delivery details are only visible
            lbl_delivery.Visible = true;
            lbl_Deliveryy.Visible = true;
            lbl_myorderFrom.Visible = true;
            lbl_RestaurantName.Visible = true;
            lbl_tax.Visible = true;
            lbl_totalprice.Visible = true;
            lbl_tp.Visible = true;
            listBox_Delivery.Visible = true;
            lbl_Deliveryplace.Visible = true;   
            comboBox_deliveryplace.Visible = true;
            
            
            
            //////////////////////////////////////

            btn_hardees.Visible = false;
            btn_kfc.Visible = false;
            btn_mcdonalds.Visible = false;
            btn_nola.Visible = false;
            btn_papajohns.Visible = false;

            lbl_hardees.Visible = false;
            lbl_kfc.Visible = false;
            lbl_mcdonalds.Visible = false;
            lbl_nola.Visible = false;
            lbl_papaJohns.Visible = false;

            /////////////////////////////////////
            ///

            ////////////////////////////////////

            Food del = new Hardees(); // upcasting 


            if (total_price == 0)
            {
                lbl_delivery.Text = "0";
                lbl_RestaurantName.Text = "";
                lbl_totalprice.Text = "0";

            }
            else
            {
                lbl_delivery.Text = Convert.ToString(del.delivery);
                lbl_RestaurantName.Text = myOrderFrom;
                lbl_totalprice.Text = Convert.ToString(total_price + del.delivery);

                for (int i = 0; i < NumberofItems.Length; i++)
                {
                    if (NumberofItems[i] != 0)
                        listBox_Delivery.Items.Add(NumberofItems[i] + " " + ListofItems[i]);

                }

            }


        }

        

        private void btn_hardees_Click_1(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            HardeesForm hardeesform = new HardeesForm(UserName);
            hardeesform.Show();
            this.Hide();

        }

        private void btn_papajohns_Click_1(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            PapaJohnsForm papajohnsform = new PapaJohnsForm(UserName);
            papajohnsform.Show();
            this.Hide();

        }

        private void btn_mcdonalds_Click_1(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            McdonaldsForm mcdonaldsform = new McdonaldsForm(UserName);
            mcdonaldsform.Show();
            this.Hide();
        }

        private void btn_kfc_Click_1(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            KfcForm kfcform = new KfcForm(UserName);
            kfcform.Show();
            this.Hide();
        }

        private void btn_nola_Click_1(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            NolaForm nolaform = new NolaForm(UserName);
            nolaform.Show();
            this.Hide();
        }

        private void btn_hardees_Click(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            HardeesForm hardeesform = new HardeesForm(UserName);
            hardeesform.Show();
            this.Hide();

        }

        private void btn_papajohns_Click(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            PapaJohnsForm papajohnsform = new PapaJohnsForm(UserName);
            papajohnsform.Show();
            this.Hide();

        }

        private void btn_mcdonalds_Click(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            McdonaldsForm mcdonaldsform = new McdonaldsForm(UserName);
            mcdonaldsform.Show();
            this.Hide();
        }

        private void btn_kfc_Click(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            KfcForm kfcform = new KfcForm(UserName);
            kfcform.Show();
            this.Hide();
        }

        private void btn_nola_Click(object sender, EventArgs e)
        {
            //when we click on the button, we go to the new form and exit this one
            NolaForm nolaform = new NolaForm(UserName);
            nolaform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_username.Visible = true;
            lbl_user.Visible = true;
            lbl_username.Text = UserName;
            lbl_Deliveryplace.Visible = false;
            comboBox_deliveryplace.Visible = false;

            if (myOrderFrom == null)
            {

                lbl_delivery.Visible = false;
                lbl_Deliveryy.Visible = false;
                lbl_myorderFrom.Visible = false;
                lbl_RestaurantName.Visible = false;
                lbl_tax.Visible = false;
                lbl_totalprice.Visible = false;
                lbl_tp.Visible = false;
                listBox_Delivery.Visible = false;

               

                btn_hardees.Visible = false;
                btn_kfc.Visible = false;
                btn_mcdonalds.Visible = false;
                btn_nola.Visible = false;
                btn_papajohns.Visible = false;

                lbl_hardees.Visible = false;
                lbl_kfc.Visible = false;
                lbl_mcdonalds.Visible = false;
                lbl_nola.Visible = false;
                lbl_papaJohns.Visible = false;




            }

            else
            {


                panelOver.Hide();

                lbl_delivery.Visible = true;
                lbl_Deliveryy.Visible = true;
                lbl_myorderFrom.Visible = true;
                lbl_RestaurantName.Visible = true;
                lbl_tax.Visible = true;
                lbl_totalprice.Visible = true;
                lbl_tp.Visible = true;
                listBox_Delivery.Visible = true;
                lbl_Deliveryplace.Visible = true;
                comboBox_deliveryplace.Visible = true;

                ///////////////////////////////
                ///

                btn_hardees.Visible = false;
                btn_kfc.Visible = false;
                btn_mcdonalds.Visible = false;
                btn_nola.Visible = false;
                btn_papajohns.Visible = false;

                lbl_hardees.Visible = false;
                lbl_kfc.Visible = false;
                lbl_mcdonalds.Visible = false;
                lbl_nola.Visible = false;
                lbl_papaJohns.Visible = false;
                /////////////////////////////////
                ///

                Food del = new Hardees(); //up casting


                if (total_price == 0)
                {
                    lbl_delivery.Text = "0";
                    lbl_RestaurantName.Text = "";
                    lbl_totalprice.Text = "0";

                }
                else
                {
                    lbl_delivery.Text = Convert.ToString(del.delivery); //delivery variable from class Food inherited by all classes
                    lbl_RestaurantName.Text = myOrderFrom;
                    lbl_totalprice.Text = Convert.ToString(total_price + del.delivery);



                    //el fatooora: what we ordered
                    for(int i = 0; i < NumberofItems.Length; i++)
                    {
                        if(NumberofItems[i] != 0)
                        listBox_Delivery.Items.Add(NumberofItems[i]+" "+ ListofItems[i]);

                    }

                }



            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show(); 
            this.Hide();
        }

        private void listBox_Delivery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

