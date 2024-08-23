using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ItemIQ
{
    public partial class CreateReview : Form
    {
        public CreateReview()
        {
            InitializeComponent();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string UserName = Form1.Username;
            txtUsername.Text = UserName;
            string ItemInfomationName = MainPage.ItemInfomationName;
            string filePath = $"Data\\Reviews\\{ItemInfomationName}.xml";

            string Username = txtUsername.Text, Date = txtDate.Text, ReviewInfo = txtReviewInfo.Text, ReviewRating = txtReviewRating.Text;

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
                    xmlWriter.WriteStartElement("Reviews");         //writing to xml login details of the user that  they have put in so that it can be read later

                    xmlWriter.WriteStartElement("Review");
                    xmlWriter.WriteElementString("Username", Username.Trim());
                    xmlWriter.WriteElementString("Date", Date.Trim());
                    xmlWriter.WriteElementString("ReviewInfo", ReviewInfo.Trim());
                    xmlWriter.WriteElementString("ReviewRating", ReviewRating.Trim());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(filePath);
                XElement root = xDocument.Element("Reviews");
                if (root != null)
                {
                    root.Add(new XElement("Review",                            //if the xml file already exist it just updates the file with more details of login user so that they can be read later
                        new XElement("Username", Username.Trim()),
                        new XElement("Date", Date.Trim()),
                        new XElement("ReviewInfo", ReviewInfo.Trim()),
                        new XElement("ReviewRating", ReviewRating.Trim())));
                    xDocument.Save(filePath); //Saving the file
                }
            }
            this.Hide();
            // Create a new instance of ChecklistPage form
            ItemInfo Iteminfo = new ItemInfo();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Iteminfo.Closed += (s, args) => this.Close();

            // Display a form
            Iteminfo.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of ChecklistPage form
            ItemInfo Iteminfo = new ItemInfo();

            // Subscribe to the Closed event of form to close the current form when other form is closed
            Iteminfo.Closed += (s, args) => this.Close();

            // Display a form
            Iteminfo.Show();
        }
    }
}
