using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text.RegularExpressions;

namespace ItemIQ
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        public static bool Payedfor = false;
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

        private void btnChecklist_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ChecklistPage form
            Checklist Checklistpage = new Checklist();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Checklistpage.Closed += (s, args) => this.Close();

            // Display a form
            Checklistpage.Show(); ;
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

        private void Checkout_Load(object sender, EventArgs e)
        {
            string UserName = Form1.Username;
            string filePath = $"Data\\CartOrders\\{UserName}_CartOrder.xml"; // variables and file path for xml writer
            float Totalforwholecart = 0;
            string ItemName = "", Price = "", Numberofitem = "";
            try
            {
                using (XmlReader reader = XmlReader.Create(filePath)) // Xml reader which reads a xml file full of login data to see if you aloowed into the app 
                {

                    while (reader.Read()) // while reading the file it excutes the code within it
                    {
                        if (reader.IsStartElement()) // finds the starter element within the xml file
                        {

                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "ItemName":       //Store the data element for itemname
                                    ItemName = reader.ReadString();
                                    break;
                                case "ItemPrice":   //Store the data element for itemprice
                                    Price = reader.ReadString();
                                    break;
                                case "NumberItem":  //Store the data element for itemname
                                    Numberofitem = reader.ReadString();
                                    float TotalPrice = float.Parse(Price) * float.Parse(Numberofitem);
                                    ListViewItem listItem = new ListViewItem();   //"Row" object.
                                    listItem.Text = ItemName;   
                                    listItem.SubItems.Add(Price);       //createss a listview objects and adds data to it from the xml file and displayys the data in a listview box
                                    listItem.SubItems.Add(Numberofitem);
                                    listItem.SubItems.Add($"{TotalPrice}");
                                    Totalforwholecart = Totalforwholecart + TotalPrice;
                                    lblTotalPrice.Text = "Total Price for cart: " + $"{Totalforwholecart}";
                                    if (ItemName != "" && Price != "" && Numberofitem != "")   //if field all have values
                                    {
                                        lsvCartList.Items.Add(listItem);      //display entire listview row
                                    }
                                    break;
                            }

                        }

                    }

                }
            }
            catch 
            { 

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Regex objAlphaPattern = new Regex("[a-zA-Z][a-zA-Z]");       //regex
            Regex objNumberPattern = new Regex("[0-9.-]$");

            if (txtCardName.Text == "" || txtCardNumber.Text == "" || txtCardDate.Text == "" || txtCardCvc.Text == "") //existence vaidation
            {
                MessageBox.Show("Make sure to fill in all fields of data so we can process your payment!, Thank You");
            }
            else if (!objAlphaPattern.IsMatch(txtCardName.Text) || !objNumberPattern.IsMatch(txtCardNumber.Text) || !objNumberPattern.IsMatch(txtCardCvc.Text)) //type vaidation
            {
                MessageBox.Show("Make sure to fill in all fields of the right type of data so we can process your payment!, Thank You");
            }
            else
            {
                Payedfor = true; // sets payfor to true (very important)
            }
        }
    }
}
