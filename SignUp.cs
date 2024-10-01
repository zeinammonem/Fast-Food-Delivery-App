using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //database lib

namespace FastFoodAppFinal
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        string connectionString = @"Data Source=DESKTOP-AT8118D;Initial Catalog=FastFoodAppDB;Integrated Security=True";


        private void textBoxUsernameUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsernameUp.Text == "" || textBoxPasswordUp.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Registration Failed, please enter your full details");

            }
            else if (textBoxPasswordUp.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords does not match, please re-enter the password");
                textBoxPasswordUp.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPasswordUp.Focus(); //bnrakez 3al password

            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon); //name of query and connection
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    // sqlCmd.Parameters.AddWithValue("set identity_insert tblUser on");
                    sqlCmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(textBoxPhoneNumber.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@UserName", textBoxUsernameUp.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBoxPasswordUp.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Success");
                    Clear();

                  
                    

                    WelcomePage welcomePage = new WelcomePage();
                    welcomePage.Show();
                    this.Hide();



                }
                void Clear() //function to clear text boxes
                {
                    textBoxPasswordUp.Text = textBoxConfirmPassword.Text = textBoxEmail.Text =textBoxUsernameUp.Text=textBoxPhoneNumber.Text= "";
                }

            }





                WelcomePage welcomepage = new WelcomePage();
            this.Hide();
            welcomepage.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            WelcomePage welcomepage=new WelcomePage();
            this.Hide();
            welcomepage.Show();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPasswordUp.PasswordChar = '\0'; //to show the password
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordUp.PasswordChar = '*'; //hide password
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPasswordUp.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
        }
    }
}
