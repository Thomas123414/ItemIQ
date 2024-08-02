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

        public void Additemtocart(string ItemName, string ItemPrice)
        {
            bool Payed = Checkout.Payedfor;

            string UserName = Form1.Username;
            string PassWord = Form1.Password;
            string Email = Form1.Email;
            string filePathSettings = "C:\\Users\\AND0043\\Desktop\\testingforcode\\" + $"{UserName}.xml";
            Random rnd = new Random();
            string CartOrderID = UserName + "_CartOrder";
            string filePath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\CartOrders\\{CartOrderID}.xml";
            if (File.Exists(filePath) && Payed == true)
            {
                var sourcePath = filePath;
                var destinationPath = $"C:\\Users\\AND0043\\Desktop\\testingforcode\\Pastorders\\Last_{CartOrderID}.xml";
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }
                File.Move(sourcePath, destinationPath);
                File.Delete(sourcePath);
                var doc = XDocument.Load(filePathSettings);
                var node = doc.Descendants("Personal").FirstOrDefault(Player => Player.Element("SessionID").Value == "0");
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
                    xmlWriter.WriteStartElement("Cart");

                    xmlWriter.WriteStartElement("Product");
                    xmlWriter.WriteElementString("ItemName", ItemName.Trim());
                    xmlWriter.WriteElementString("ItemPrice", ItemPrice);
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
                    root.Add(new XElement("Product",
                        new XElement("ItemName", ItemName.Trim()),
                        new XElement("ItemPrice", ItemPrice)));
                    xDocument.Save(filePath);
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
            this.Hide();
            // Create a new instance of StaffMainScreen form
            Checkout Checkoutpage = new Checkout();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            Checkoutpage.Closed += (s, args) => this.Close();

            // Display form2
            Checkoutpage.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            addingproducts addingproducts = new addingproducts();
            // Create a new instance of StaffMainScreen form
            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            addingproducts.Closed += (s, args) => this.Close();

            // Display form2
            addingproducts.Show();
        }

        private void btnChecklist_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            Checklist Checklistpage = new Checklist();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            Checklistpage.Closed += (s, args) => this.Close();

            // Display form2
            Checklistpage.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            Personal Profilepage = new Personal();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            Profilepage.Closed += (s, args) => this.Close();

            // Display form2
            Profilepage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            Form1 Loginpage = new Form1();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            Loginpage.Closed += (s, args) => this.Close();

            // Display form2
            Loginpage.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\Productdetails.xml";
            float Price = 100;
            string ID = "", Link = "", nameItem = "", desItem = "";
            string priceItem = "";
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
                                        lblRecommendItemText.Text = desItem;
                                        lblRecommendItem.Text = "Item: " + nameItem;
                                        lblRecommendPrice.Text = "Price: " + priceItem;
                                        string PicPath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\" + Link;
                                        PicRecommend.Image = Image.FromFile(PicPath);
                                    }
                                }
                                break;
                        }

                    }

                }

            }
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
            Additemtocart("Cucumber", "1.78");
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            Additemtocart("Pumpkin", "6.0");
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            Additemtocart("Apple", "0.78");
        }
    }
}
