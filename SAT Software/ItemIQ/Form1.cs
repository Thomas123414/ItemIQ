using System.Xml;
using System.Xml.Linq;

namespace ItemIQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Username = "";     // public variables so that i can grab this data whenever on the app
        public static string Password = "";
        public static string Email = "";
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();    //clears the textboxs when login form is loaded so that it can be easily used
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; //variables for data
            string password = txtPassword.Text;
            bool LoginDetails = false;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in your data so that we can process your login request!");
            }
            else
            {
                string filePath = "Data\\LoginDetails.xml"; // pathway in the system to the xml file so i can find it when i need to use it 

                string currentUsernames = "", currentEmails = "", currentPasswords = ""; //variables for data
                using (XmlReader reader = XmlReader.Create(filePath)) // Xml reader which reads a xml file full of login data to see if you aloowed into the app 
                {

                    while (reader.Read()) // while reading the file it excutes the code within it
                    {
                        if (reader.IsStartElement()) // finds the starter element within the xml file
                        {

                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "User":       //Store the data element firstname 
                                    currentUsernames = reader.ReadString();
                                    break;
                                case "Email":
                                    currentEmails = reader.ReadString();
                                    break;
                                case "Password":
                                    currentPasswords = reader.ReadString();
                                    if (username == currentUsernames && password == currentPasswords)
                                    {
                                        LoginDetails = true;
                                        Email = currentEmails;
                                    }
                                    break;
                            }

                        }

                    }

                }

                if (LoginDetails == true)
                {
                    Username = txtUsername.Text;
                    Password = txtPassword.Text;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.Hide();
                    // Create a new instance of MainPage form
                    MainPage mainPage = new MainPage();

                    // Subscribe to the Closed event of form to close the current form when other form is closed
                    mainPage.Closed += (s, args) => this.Close();

                    // Display a form
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Login Details are not correct! Please try again"); //vaidaition
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of SignUpPage form
            SignUp signUp = new SignUp();

            // Subscribe to the Closed event of formto close the current form when other form is closed
            signUp.Closed += (s, args) => this.Close();

            // Display a form
            signUp.Show();
        }
    }
}
