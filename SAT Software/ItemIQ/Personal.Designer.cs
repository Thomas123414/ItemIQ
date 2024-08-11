namespace ItemIQ
{
    partial class Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            btnLogOut = new Button();
            btnProfile = new Button();
            btnChecklist = new Button();
            btnCheckout = new Button();
            btnHome = new Button();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSaveDetails = new Button();
            label4 = new Label();
            lsvCartList = new ListView();
            ItemName = new ColumnHeader();
            Price = new ColumnHeader();
            NumberOfItems = new ColumnHeader();
            TotalItemPrice = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.DarkSlateBlue;
            btnLogOut.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(811, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(202, 63);
            btnLogOut.TabIndex = 13;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DarkSlateBlue;
            btnProfile.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(603, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(202, 63);
            btnProfile.TabIndex = 12;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnChecklist
            // 
            btnChecklist.BackColor = Color.DarkSlateBlue;
            btnChecklist.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnChecklist.Image = (Image)resources.GetObject("btnChecklist.Image");
            btnChecklist.ImageAlign = ContentAlignment.MiddleRight;
            btnChecklist.Location = new Point(394, 2);
            btnChecklist.Name = "btnChecklist";
            btnChecklist.Size = new Size(202, 63);
            btnChecklist.TabIndex = 11;
            btnChecklist.Text = "Checklist";
            btnChecklist.UseVisualStyleBackColor = false;
            btnChecklist.Click += btnChecklist_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.DarkSlateBlue;
            btnCheckout.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = ContentAlignment.MiddleRight;
            btnCheckout.Location = new Point(196, 2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(202, 63);
            btnCheckout.TabIndex = 10;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkSlateBlue;
            btnHome.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(1, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 63);
            btnHome.TabIndex = 9;
            btnHome.Text = "HomePage";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(578, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(372, 23);
            txtUsername.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 71);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 16;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(504, 127);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 17;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(469, 187);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 18;
            label3.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(578, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(578, 187);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(372, 23);
            txtPassword.TabIndex = 20;
            // 
            // btnSaveDetails
            // 
            btnSaveDetails.BackColor = Color.DarkSlateBlue;
            btnSaveDetails.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveDetails.Location = new Point(578, 260);
            btnSaveDetails.Name = "btnSaveDetails";
            btnSaveDetails.Size = new Size(319, 41);
            btnSaveDetails.TabIndex = 21;
            btnSaveDetails.Text = "Save Your Details!";
            btnSaveDetails.UseVisualStyleBackColor = false;
            btnSaveDetails.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 314);
            label4.Name = "label4";
            label4.Size = new Size(227, 31);
            label4.TabIndex = 22;
            label4.Text = "Last Order Invoice:";
            // 
            // lsvCartList
            // 
            lsvCartList.Columns.AddRange(new ColumnHeader[] { ItemName, Price, NumberOfItems, TotalItemPrice });
            lsvCartList.Location = new Point(12, 348);
            lsvCartList.Name = "lsvCartList";
            lsvCartList.Size = new Size(975, 322);
            lsvCartList.TabIndex = 23;
            lsvCartList.UseCompatibleStateImageBehavior = false;
            lsvCartList.View = View.Details;
            // 
            // ItemName
            // 
            ItemName.Text = "ItemName:";
            ItemName.Width = 400;
            // 
            // Price
            // 
            Price.Text = "Price:";
            Price.Width = 180;
            // 
            // NumberOfItems
            // 
            NumberOfItems.Text = "# of Item";
            NumberOfItems.Width = 180;
            // 
            // TotalItemPrice
            // 
            TotalItemPrice.Text = "Total Price for Item";
            TotalItemPrice.Width = 180;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1013, 682);
            Controls.Add(lsvCartList);
            Controls.Add(label4);
            Controls.Add(btnSaveDetails);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfile);
            Controls.Add(btnChecklist);
            Controls.Add(btnCheckout);
            Controls.Add(btnHome);
            Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Personal";
            Text = "Personal";
            Load += Personal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnProfile;
        private Button btnChecklist;
        private Button btnCheckout;
        private Button btnHome;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSaveDetails;
        private Label label4;
        private ListView lsvCartList;
        private ColumnHeader ItemName;
        private ColumnHeader Price;
        private ColumnHeader NumberOfItems;
        private ColumnHeader TotalItemPrice;
    }
}