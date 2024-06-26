using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemIQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Auth(string Username, string Password )
        {
            int Val = 3;
            return Val;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp SignUp = new SignUp();
            this.Hide();
            SignUp.ShowDialog();  //This whole object purpose is to set the form Home to a variable then with that varaible open the form so that i can transfer between pages
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (Username == "" || Password == "")
            {
                MessageBox.Show("Fill out details before trying to login!");
            }
            else
            {
                int AuthCorrect = Auth(Username, Password);
                if (AuthCorrect == 1)
                {
                    HomePage HomePage = new HomePage();
                    this.Hide();
                    HomePage.ShowDialog();  //This whole object purpose is to set the form Home to a variable then with that varaible open the form so that i can transfer between pages
                    this.Close();
                }
                else if (AuthCorrect == 2)
                {
                    MessageBox.Show("Incorrect Email or Password, Try Again");
                }
                else if (AuthCorrect == 3)
                {
                    MessageBox.Show("Error: CIWCA24051, Try Again");
                }
            }
        }
    }
}
