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
using System.Xml.Linq;

namespace ItemIQ
{
    public partial class Personal : Form
    {
        public Personal()
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

        private void btnChecklist_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ChecklistPage form
            Checklist Checklistpage = new Checklist();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Checklistpage.Closed += (s, args) => this.Close();

            // Display a form
            Checklistpage.Show();
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

        private void Personal_Load(object sender, EventArgs e)
        {
            string PassWord = Form1.Password;
            string Email = Form1.Email;
            string UserName = Form1.Username;
                                                    //variables for data to read from
            txtUsername.Text = UserName;
            txtEmail.Text = Email;
            txtPassword.Text = PassWord;

            try
            {
                string filePath = $"Data\\Pastorders\\Last_{UserName}_CartOrder.xml";
                float Totalforwholecart = 0;
                string ItemName = "", Price = "", Numberofitem = "";
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
                                    ItemName = reader.ReadString();
                                    break;
                                case "ItemPrice":        //Store the data element itemrpice
                                    Price = reader.ReadString();
                                    break;
                                case "NumberItem":           //Store the data element numberitem
                                    Numberofitem = reader.ReadString(); 
                                    float TotalPrice = float.Parse(Price) * float.Parse(Numberofitem);
                                    ListViewItem listItem = new ListViewItem();   //"Row" object.
                                    listItem.Text = ItemName;
                                    listItem.SubItems.Add(Price);   //reads from past order file then grabs all that data and adds that data to a new listview object which then displays it in a listview box
                                    listItem.SubItems.Add(Numberofitem);
                                    listItem.SubItems.Add($"{TotalPrice}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*string UserName = Form1.Username;
            string PassWord = Form1.Password;
            string Email = Form1.Email;
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\LoginDetails.xml";

            var doc = XDocument.Load(filePath);
            var node = doc.Descendants("Detail").FirstOrDefault(Player => Player.Element("User").Value == $"{UserName}");
            node.SetElementValue("User", txtUsername.Text);
            node.SetElementValue("Email", txtEmail.Text);
            node.SetElementValue("Password", txtPassword.Text);
            //Save the changes to the file
            doc.Save(filePath);*/

            //^doesnt work needs heaps of code to be changed for this to be implemented so i have just hidden it with a comment
        }
    }
}
