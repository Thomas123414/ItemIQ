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
        public static string Username = "";
        public static string Password = "";
        public static string Email = "";
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool LoginDetails = false;
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\LoginDetails.xml";

            string currentUsernames = "", currentEmails = "", currentPasswords = "";
            using (XmlReader reader = XmlReader.Create(filePath))
            {

                while (reader.Read())
                {
                    // ListViewItem listItem = new ListViewItem();   //"Row" object.
                    if (reader.IsStartElement())
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
                                if (username == currentUsernames || password == currentPasswords)
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
                // Create a new instance of StaffMainScreen form
                MainPage mainPage = new MainPage();

                // Subscribe to the Closed event of form2 to close the current form when form2 is closed
                mainPage.Closed += (s, args) => this.Close();

                // Display form2
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Login Details are not correct! Please try again");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            SignUp signUp = new SignUp();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            signUp.Closed += (s, args) => this.Close();

            // Display form2
            signUp.Show();
        }
    }
}
