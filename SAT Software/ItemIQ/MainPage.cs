using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace ItemIQ
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Additemtocart(string ItemName, string ItemPrice, string NumberItem)
        {
            bool Payed = Checkout.Payedfor;

            string UserName = Form1.Username;
            string PassWord = Form1.Password;   //variables for data
            string Email = Form1.Email;
            string filePathSettings = "C:\\Users\\AND0043\\Desktop\\testingforcode\\" + $"{UserName}.xml"; //file paths 
            string CartOrderID = UserName + "_CartOrder";
            string filePath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\CartOrders\\{CartOrderID}.xml";
            if (File.Exists(filePath) && Payed == true)
            {
                var sourcePath = filePath; //file paths
                var destinationPath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\Pastorders\\Last_{CartOrderID}.xml";
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);       //deleting existing file if they exist
                }
                File.Move(sourcePath, destinationPath);     //moving the file to a different location
                File.Delete(sourcePath);
                var doc = XDocument.Load(filePathSettings);
                var node = doc.Descendants("Personal").FirstOrDefault(Player => Player.Element("SessionID").Value == "0"); //editing a xml file so that i can lastcartid for future readin of the data
                node.SetElementValue("LastCartOrderID", $"Last_{CartOrderID}.xml");
                //Save the changes to the file
                doc.Save(filePathSettings);
            }
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
                    xmlWriter.WriteStartElement("Cart");         //writing to xml login details of the user that  they have put in so that it can be read later

                    xmlWriter.WriteStartElement("Product");
                    xmlWriter.WriteElementString("ItemName", ItemName.Trim());
                    xmlWriter.WriteElementString("ItemPrice", ItemPrice);
                    xmlWriter.WriteElementString("NumberItem", NumberItem);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(filePath);
                XElement root = xDocument.Element("Cart");
                if (root != null)
                {   
                    root.Add(new XElement("Product",                            //if the xml file already exist it just updates the file with more details of login user so that they can be read later
                        new XElement("ItemName", ItemName.Trim()),
                        new XElement("ItemPrice", ItemPrice),
                        new XElement("NumberItem", NumberItem)));
                    xDocument.Save(filePath); //Saving the file
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnChecklist_Click(object sender, EventArgs e)
        {
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void lblRecommendItemText_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            Additemtocart("Cucumber", "1.78", "3"); //adds cucumber to cart which $1.78 for 3 and adds it to cart when the button btncart1 is clicked
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            Additemtocart("Pumpkin", "6.0", "1");   //adds Pumpkin to cart which $6 for 1 and adds it to cart when the button btncart2 is clicked
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            Additemtocart("Apple", "0.78", "8");    //adds Apple to cart which $0.78 for 8 and adds it to cart when the button btncart3 is clicked
        }

        private void btnChecklist_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ChecklistPage form
            Checklist Checklistpage = new Checklist();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Checklistpage.Closed += (s, args) => this.Close();

            // Display a form
            Checklistpage.Show();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Checkout Checkout = new Checkout();
            // Create a new instance of Checkout form
            // Subscribe to the Closed event of form to close the current form when other form is closed
            Checkout.Closed += (s, args) => this.Close();

            // Display a form
            Checkout.Show();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addingproducts addingproducts = new addingproducts();
            // Create a new instance of AddingProducts form
            // Subscribe to the Closed event of form to close the current form when other form is closed
            addingproducts.Closed += (s, args) => this.Close();

            // Display a form
            addingproducts.Show();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ProfilePage form
            Personal Profilepage = new Personal();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Profilepage.Closed += (s, args) => this.Close();

            // Display a form
            Profilepage.Show();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of LoginPage form
            Form1 Loginpage = new Form1();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Loginpage.Closed += (s, args) => this.Close();

            // Display a form
            Loginpage.Show();
        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {

        }

        private void btnNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            Additemtocart("Taco Shells", "5.5", "6");   //adds taco shells to cart which $5.5 for 6 and adds it to cart when the button btncart4 is clicked
        }

        private void btnItem5_Click(object sender, EventArgs e)
        {
            Additemtocart("WinterVegs", "5", "4");      //adds wintervegs to cart which $5 for 4 and adds it to cart when the button btncart5 is clicked
        }

        private void btnItem6_Click(object sender, EventArgs e)
        {
            Additemtocart("Rice Bubbles", "10", "3");   //adds rice bubbles to cart which $10 for 3 and adds it to cart when the button btncart6 is clicked
        }

        private void MainPage_Load_1(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\Productdetails.xml"; //file path for xml writer 
            float Price = 100;
            string ID = "", Link = "", nameItem = "", desItem = ""; //variables for data
            string priceItem = "";
            using (XmlReader reader = XmlReader.Create(filePath)) //xml writer reading path and opening file
            {

                while (reader.Read())
                {
                    // ListViewItem listItem = new ListViewItem();   //"Row" object.
                    if (reader.IsStartElement())
                    {

                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "ID":       //Store the data element firstname 
                                ID = reader.ReadString();
                                break;
                            case "Link":
                                Link = reader.ReadString();
                                break;
                            case "nameItem":
                                nameItem = reader.ReadString();
                                break;
                            case "desItem":
                                desItem = reader.ReadString();
                                break;
                            case "priceItem":
                                priceItem = reader.ReadString();
                                if (!string.IsNullOrEmpty(priceItem) && float.TryParse(priceItem, out float parsedPrice))
                                {
                                    if (parsedPrice < Price)
                                    {
                                        Price = parsedPrice;
                                        lblRecommendItemText.Text = desItem;    //recommends item based off lowest price
                                        lblRecommendItem.Text = "Item: " + nameItem;
                                        lblRecommendPrice.Text = "Price: " + priceItem;
                                        string PicPath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\" + Link;  //then displays the picture and info of that recommend item
                                        PicRecommend.Image = Image.FromFile(PicPath);
                                    }
                                }
                                break;
                        }

                    }

                }

            }
        }
    }
}
