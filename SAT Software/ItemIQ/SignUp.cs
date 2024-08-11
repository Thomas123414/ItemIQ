using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ItemIQ
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();    //clearing data 
            txtEmail.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text; //variables for my data
            string SessionId = username;
            bool Usernamealreadyexists = false; //booleans expresssions
            bool Emailalreadyexists = false;
            bool Existingdetails = false;
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\LoginDetails.xml";  //file path to the location of the xml file i need

            string currentUsernames = "", currentEmails = "", currentPasswords = ""; //variables for my data
            if (File.Exists(filePath))
            {
                using (XmlReader reader = XmlReader.Create(filePath)) // enables xml reader for to look at filepath which is location of file
                {

                    while (reader.Read())
                    {
                        //when reading it starts at the first element
                        if (reader.IsStartElement())
                        {

                            //switch statement/ if statement to read through each subelement and give me the data back
                            switch (reader.Name.ToString())
                            {
                                case "User":       //reads data relating to "User"
                                    currentUsernames = reader.ReadString();
                                    break;
                                case "Email":   //reads data relating to "User"
                                    currentEmails = reader.ReadString();
                                    break;
                                case "Password":    //reads data relating to "User"
                                    currentPasswords = reader.ReadString();
                                    break;
                            }
                            if (username == currentUsernames || email == currentEmails) //vaidation for existing details so that there cant be the same profiles as each other 
                            {
                                Existingdetails = true;
                                if (username == currentUsernames) //individual details
                                {
                                    Usernamealreadyexists = true;
                                }
                                if (email == currentEmails)     //individual details
                                {
                                    Emailalreadyexists = true;
                                }
                            }

                        }

                    }

                }
            }

            if (Existingdetails == true)    //vaidation for existing details
            {
                if (Usernamealreadyexists == true) //to tell the user that it is alreayd been used
                {
                    MessageBox.Show("Username is already used! Try again with different Username");
                }
                if (Emailalreadyexists == true)     //to tell the user that it is alreayd been used
                {
                    MessageBox.Show("Email is already used! Try again with different Email");
                }
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) // existence vaidation to make sure you fill in every textbox required 
            {
                MessageBox.Show("Make sure to fill in all your details!");
                return;
            }
            else
            {

                try
                {
                    if (!File.Exists(filePath))
                    {
                        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                        {
                            Indent = true,
                            NewLineOnAttributes = true
                        };
                        using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSettings))
                        {
                            xmlWriter.WriteStartDocument();                         //writing to xml login details of the user that  they have put in so that it can be read later
                            xmlWriter.WriteStartElement("Details");

                            xmlWriter.WriteStartElement("Detail");
                            xmlWriter.WriteElementString("User", username.Trim());
                            xmlWriter.WriteElementString("Email", email.Trim());
                            xmlWriter.WriteElementString("Password", password.Trim());
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndDocument();
                        }
                        this.Hide();
                        // Create a new instance of LoginPage form
                        Form1 LoginPage = new Form1();

                        // Subscribe to the Closed event of form to close the current form when other form is closed
                        LoginPage.Closed += (s, args) => this.Close();

                        // Display a form
                        LoginPage.Show();
                    }
                    else
                    {
                        XDocument xDocument = XDocument.Load(filePath);
                        XElement root = xDocument.Element("Details");
                        if (root != null)
                        {
                            root.Add(new XElement("Detail",                     //if the xml file already exist it just updates the file with more details of login user so that they can be read later
                                new XElement("User", username.Trim()),
                                new XElement("Email", email.Trim()),
                                new XElement("Password", password.Trim())));
                            xDocument.Save(filePath);       //saving file
                        }
                        this.Hide();
                        // Create a new instance of LoginPage form
                        Form1 LoginPage = new Form1();

                        // Subscribe to the Closed event of form to close the current form when other form is closed
                        LoginPage.Closed += (s, args) => this.Close();

                        // Display a form
                        LoginPage.Show();
                    }
                    string filePathSettings = "C:\\Users\\AND0043\\Desktop\\testingforcode\\" + $"{username}.xml";
                    if (!File.Exists(filePathSettings))
                    {
                        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                        {
                            Indent = true,
                            NewLineOnAttributes = true
                        };
                        using (XmlWriter xmlWriter = XmlWriter.Create(filePathSettings, xmlWriterSettings))
                        {
                            xmlWriter.WriteStartDocument();
                            xmlWriter.WriteStartElement("PersonalSettings");            //writing to xml login details of the user that  they have put in so that it can be read later

                            xmlWriter.WriteStartElement("Personal");
                            xmlWriter.WriteElementString("SessionID", "0");
                            xmlWriter.WriteElementString("LastCartOrderID", "");
                            xmlWriter.WriteEndElement();

                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndDocument();
                        }
                    }
                    else
                    {
                        XDocument xDocument = XDocument.Load(filePathSettings);
                        XElement root = xDocument.Element("PersonalSettings");
                        if (root != null)
                        {
                            root.Add(new XElement("Personal",                   //if the xml file already exist it just updates the file with more details of login user so that they can be read later
                                new XElement("SessionID", "0"),
                                new XElement("LastCartOrderID", "")));
                            xDocument.Save(filePath);                           //saving file 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");        //to catch errors in the code and tell you the problem
                }
            }
        }
    }
}
