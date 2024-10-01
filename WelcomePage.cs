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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

      

        

        //string connectionString = @"Data Source=DESKTOP-AT8118D;Initial Catalog=FastFoodAppDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AT8118D;Initial Catalog=FastFoodAppDB;Integrated Security=True");


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {

            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            try
            {
                string querry = "SELECT * FROM tblUser WHERE UserName = '"+textBoxUser.Text+"' AND Password = '"+textBoxPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = textBoxUser.Text;
                    password = textBoxPassword.Text;

                    
                    Form1 form1 = new Form1(username); // n3ml database w n-enter the name of the person who is ordering 
                    this.Hide();
                    form1.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Login","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBoxUser.Clear();
                    textBoxPassword.Clear();

                    //to focus on username
                    textBoxUser.Focus();
                }

               

            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
            finally
            {
                conn.Close();
            }







        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
    }

