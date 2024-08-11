using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

namespace ItemIQ
{
    public partial class Checklist : Form
    {
        public Checklist()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of HomePage form
            MainPage MainPage = new MainPage();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            MainPage.Closed += (s, args) => this.Close();

            // Display a form
            MainPage.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout Checkout = new Checkout();
            // Create a new instance of Checkout form
            // Subscribe to the Closed event of form to close the current form when other form is closed
            Checkout.Closed += (s, args) => this.Close();

            // Display a form
            Checkout.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ProfilePage form
            Personal Profilepage = new Personal();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Profilepage.Closed += (s, args) => this.Close();

            // Display a form
            Profilepage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of LoginPage form
            Form1 Loginpage = new Form1();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Loginpage.Closed += (s, args) => this.Close();

            // Display a form
            Loginpage.Show();
        }

        private void Checklist_Load(object sender, EventArgs e)
        {
            string UserName = Form1.Username;
            string PassWord = Form1.Password;
            string Email = Form1.Email;                 //variables for data and file path for xml writer to read from
            float TotalPrice = 0;
            string filePath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\Checklist\\{UserName}_Checklist.xml";

            if (File.Exists(filePath))
            {
                string Itemname = "", Itemprice = "";
                using (XmlReader reader = XmlReader.Create(filePath)) // Xml reader which reads a xml file full of login data to see if you aloowed into the app 
                {

                    while (reader.Read()) // while reading the file it excutes the code within it
                    {
                        if (reader.IsStartElement()) // finds the starter element within the xml file
                        {

                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "ItemName":       //Store the data element itemname
                                    Itemname = reader.ReadString();
                                    break;
                                case "ItemPrice":   //Store the data element itemPRICE
                                    Itemprice = reader.ReadString();
                                    CLB.Items.Add(Itemname + ", " + Itemprice);         //adds the data you got from the textboxs to the checklist box which shows all the data
                                    TotalPrice = TotalPrice + float.Parse(Itemprice);
                                    lblChecklistPrice.Text = $"Total price of list: {TotalPrice}";
                                    break;
                            }

                        }

                    }

                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChecklistAdd_Click(object sender, EventArgs e)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]");      //regex
            Regex objNumberPattern = new Regex("[0-9.-]$");


            if (txtChecklistPrice.Text == "" || txtChecklistName.Text == "")        //exxistence  check
            {
                MessageBox.Show("Please fill in the data to be able to add the item you want!");
            }
            else if (!objAlphaPattern.IsMatch(txtChecklistName.Text) || !objNumberPattern.IsMatch(txtChecklistPrice.Text)) //type check
            {
                MessageBox.Show("Please fill in the right data to be able to add the item you want!");
            }
            else
            {
                float Price = float.Parse(txtChecklistPrice.Text);
                CLB.Items.Add(txtChecklistName.Text + ", " + $"{Price}");
                string UserName = Form1.Username;
                string PassWord = Form1.Password;   //variables for data and parses a string to float and a file path for xml to read from
                string Email = Form1.Email;
                string filePath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\Checklist\\{UserName}_Checklist.xml";

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
                        xmlWriter.WriteStartElement("Checklist");                       //if the xml file already exist it just updates the file with more details of login user so that they can be read later

                        xmlWriter.WriteStartElement("Item");
                        xmlWriter.WriteElementString("ItemName", txtChecklistName.Text.Trim());
                        xmlWriter.WriteElementString("ItemPrice", txtChecklistPrice.Text.Trim());
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                    }
                }
                else
                {
                    XDocument xDocument = XDocument.Load(filePath);
                    XElement root = xDocument.Element("Checklist");
                    if (root != null)
                    {
                        root.Add(new XElement("Item",           //writing to xml login details of the user that  they have put in so that it can be read later
                            new XElement("ItemName", txtChecklistName.Text.Trim()),
                            new XElement("ItemPrice", txtChecklistPrice.Text.Trim())));
                        xDocument.Save(filePath); //saving file
                    }
                }
                txtChecklistName.Text = "";
                txtChecklistPrice.Text = "";
            }
        }
    }
}
