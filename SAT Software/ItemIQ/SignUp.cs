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
            string Username = txtUsername.Text;
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            string SettingID = Username.Remove(Username.Length - (Username.Length + 3)) + Email.Remove(Email.Length - (Email.Length + 3));
            string path = "filedetails\\LoginDetails.txt";
            if(Username == "" || Email == "" || Password == "")
            {
                MessageBox.Show("Make sure to fill in all your details!");
            }
            else if(!File.Exists(path))
            {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();  //xml settings
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create(path , xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("Details");

                        xmlWriter.WriteStartElement("Detail");
                        xmlWriter.WriteElementString("User", Username);         //xml format with creating subtags relating to varaibles i made earlier that will make the database
                        xmlWriter.WriteElementString("Email", Email);
                        xmlWriter.WriteElementString("Password", Password);
                        xmlWriter.WriteElementString("filesettingid", SettingID);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
            }
            else
            {
                XDocument xDocument = XDocument.Load(path);
                XElement root = xDocument.Element("Details");
                IEnumerable<XElement> rows = root.Descendants("Detail");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Detail",
                   new XElement("User", Username),
                   new XElement("Email", Email),
                   new XElement("Password", Password),         //xml format with creating subtags relating to varaibles i made earlier that will make the database
                   new XElement("filesettingid", SettingID)));
                xDocument.Save(path);
            }
        }
    }
}
