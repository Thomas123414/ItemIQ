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
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool Usernamealreadyexists = false;
            bool Emailalreadyexists = false;
            bool Existingdetails = false;
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\LoginDetails.xml";

            string currentUsernames = "", currentEmails = "", currentPasswords = "";
            if (File.Exists(filePath))
            {
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
                                    break;
                            }
                            if (username == currentUsernames || email == currentEmails)
                            {
                                Existingdetails = true;
                                if (username == currentUsernames)
                                {
                                    Usernamealreadyexists = true;
                                }
                                else if (email == currentEmails)
                                {
                                    Emailalreadyexists = true;
                                }
                            }

                        }

                    }

                }
            }

            if (Existingdetails == true)
            {
                if (Usernamealreadyexists == true)
                {
                    MessageBox.Show("Username is already used! Try again with different Username");
                }
                if (Emailalreadyexists == true)
                {
                    MessageBox.Show("Email is already used! Try again with different Email");
                }
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
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
                            xmlWriter.WriteStartDocument();
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
                        // Create a new instance of StaffMainScreen form
                        Form1 LoginPage = new Form1();

                        // Subscribe to the Closed event of form2 to close the current form when form2 is closed
                        LoginPage.Closed += (s, args) => this.Close();

                        // Display form2
                        LoginPage.Show();
                    }
                    else
                    {
                        XDocument xDocument = XDocument.Load(filePath);
                        XElement root = xDocument.Element("Details");
                        if (root != null)
                        {
                            root.Add(new XElement("Detail",
                                new XElement("User", username.Trim()),
                                new XElement("Email", email.Trim()),
                                new XElement("Password", password.Trim())));
                            xDocument.Save(filePath);
                        }
                        this.Hide();
                        // Create a new instance of StaffMainScreen form
                        Form1 LoginPage = new Form1();

                        // Subscribe to the Closed event of form2 to close the current form when form2 is closed
                        LoginPage.Closed += (s, args) => this.Close();

                        // Display form2
                        LoginPage.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
