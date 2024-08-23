using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ItemIQ
{
    public partial class ItemInfo : Form
    {
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            string ItemInfomationSearched = MainPage.ItemInfomationName;

            string filePath = "Data\\Productdetails.xml";
            string ID = "", Link = "", nameItem = "", desItem = ""; //variables for data
            string priceItem = "", ingredientItem = "";
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
                                break;
                            case "Ingredients":
                                ingredientItem = reader.ReadString();
                                if (ItemInfomationSearched == nameItem)
                                {
                                    string PicPath = "Data\\" + Link;  //then displays the picture and info of that recommend item
                                    PicItem.Image = Image.FromFile(PicPath);
                                    lblItemName.Text = "Item: " + nameItem;
                                    lblItemPrice.Text = "Price: $" + priceItem;
                                    lblItemDes.Text = desItem;
                                    lblItemIngredients.Text = "Ingredients: " + ingredientItem;
                                }
                                break;
                        }

                    }

                }

            }

            string UserName = Form1.Username;
            string FilePath = $"Data\\Reviews\\{ItemInfomationSearched}.xml";

            string Username = "", Date = "", ReviewInfo = "", ReviewRating = "";
            try
            {
                using (XmlReader reader = XmlReader.Create(FilePath)) // Xml reader which reads a xml file full of login data to see if you aloowed into the app 
                {

                    while (reader.Read()) // while reading the file it excutes the code within it
                    {
                        if (reader.IsStartElement()) // finds the starter element within the xml file
                        {

                            //return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "Username":       //Store the data element for itemname
                                    Username = reader.ReadString();
                                    break;
                                case "Date":   //Store the data element for itemprice
                                    Date = reader.ReadString();
                                    break;
                                case "ReviewInfo":  //Store the data element for itemname
                                    ReviewInfo = reader.ReadString();
                                    break;
                                case "ReviewRating":   //Store the data element for itemprice
                                    ReviewRating = reader.ReadString();
                                    ListViewItem listItem = new ListViewItem();   //"Row" object.
                                    listItem.Text = Username;
                                    listItem.SubItems.Add(Date);       //createss a listview objects and adds data to it from the xml file and displayys the data in a listview box
                                    listItem.SubItems.Add(ReviewInfo);
                                    listItem.SubItems.Add(ReviewRating);
                                    if (Username != "" && Date != "" && ReviewInfo != "" && ReviewRating != "")   //if field all have values
                                    {
                                        lsvReviews.Items.Add(listItem);      //display entire listview row
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

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string ItemInfomationName = MainPage.ItemInfomationName;
            ItemInfomationName = "";

            this.Hide();
            // Create a new instance of MainPage form
            MainPage mainPage = new MainPage();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            mainPage.Closed += (s, args) => this.Close();

            // Display a form
            mainPage.Show();
        }

        private void btnCreateReview_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of MainPage form
            CreateReview createreview = new CreateReview();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            createreview.Closed += (s, args) => this.Close();

            // Display a form
            createreview.Show();
        }
    }
}
