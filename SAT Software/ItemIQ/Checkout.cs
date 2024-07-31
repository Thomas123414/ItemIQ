using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemIQ
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            MainPage MainPage = new MainPage();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            MainPage.Closed += (s, args) => this.Close();

            // Display form2
            MainPage.Show();
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

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
