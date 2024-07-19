namespace ItemIQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            MainPage mainPage = new MainPage();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            mainPage.Closed += (s, args) => this.Close();

            // Display form2
            mainPage.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create a new instance of StaffMainScreen form
            SignUp signUp = new SignUp();

            // Subscribe to the Closed event of form2 to close the current form when form2 is closed
            signUp.Closed += (s, args) => this.Close();

            // Display form2
            signUp.Show();
        }
    }
}
