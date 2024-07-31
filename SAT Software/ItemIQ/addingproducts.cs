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
using System.Xml.Linq;
using System.Xml;

namespace ItemIQ
{
    public partial class addingproducts : Form
    {
        public addingproducts()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string Link = txtlink.Text;
            string name = txtname.Text;
            string des = txtdes.Text;
            string price = txtprice.Text;
            string filePath = "C:\\Users\\AND0043\\Desktop\\testingforcode\\Productdetails.xml";

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
                    xmlWriter.WriteStartElement("Products");

                    xmlWriter.WriteStartElement("Detail");
                    xmlWriter.WriteElementString("ID", id.Trim());
                    xmlWriter.WriteElementString("Link", Link);
                    xmlWriter.WriteElementString("nameItem", name.Trim());
                    xmlWriter.WriteElementString("desItem", des);
                    xmlWriter.WriteElementString("priceItem", price.Trim());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(filePath);
                XElement root = xDocument.Element("Products");
                if (root != null)
                {
                    root.Add(new XElement("Detail",
                        new XElement("ID", id.Trim()),
                        new XElement("Link", Link),
                        new XElement("nameItem", name.Trim()),
                        new XElement("desItem", des),
                        new XElement("priceItem", price.Trim())));
                    xDocument.Save(filePath);
                }
            }
            txtid.Clear();
            txtlink.Clear();
            txtname.Clear();
            txtdes.Clear();
            txtprice.Clear();
        }
    }
}
